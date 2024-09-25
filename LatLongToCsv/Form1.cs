using Microsoft.WindowsAPICodePack.Dialogs;
using SharpKml.Base;
using SharpKml.Dom;
using SharpKml.Engine;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.IO;
using System.IO.Compression;
using System.Linq;
using System.Runtime.Remoting.Contexts;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml;

namespace PdfToXlsx
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            textBoxPath.Text = Environment.GetFolderPath(Environment.SpecialFolder.Desktop);
            _currParent = treeView1.Nodes[0];
        }

        Queue<Placemark> _placemarks = new Queue<Placemark>();
        Queue<Folder> _cityFolders = new Queue<Folder>();
        Queue<Folder> _folders = new Queue<Folder>();
        TreeNode _currParent;
        private void buttonAddPlacemark_Click(object sender, EventArgs e)
        {
            Regex rgx = new Regex(@";[ \s]*|, ");
            string[] longlats;
            bool isLong = true;
            Queue<(string, double)> lons = new Queue<(string, double)>();
            Queue<(string, double)> lats = new Queue<(string, double)>();
            Placemark placemark;
            Folder folder;
            LineString line;
            List<Vector> vectors;
            int j = 1;
            if (!checkBox1.Checked)
            {
                _placemarks.Clear();
                UpdateTreeNodeItemCount();
                _currParent = treeView1.Nodes.Add("Node");
            }
            while (_latLongs.Count > 0)
            {
                (string place, string latLong) = _latLongs.Dequeue();
                longlats = rgx.Replace(latLong, ",").Split(new char[] { ',' }, StringSplitOptions.RemoveEmptyEntries);
                for (int i = 0; i < longlats.Length; i++)
                {
                    string s = LatLongFormatConverter.SeperateConsecutiveNumbers(longlats[i]);
                    double degree = LatLongFormatConverter.DMSToDD(s);
                    (string, double) pair = (s.Replace(" ", ""), degree);
                    if (isLong)
                    {
                        lons.Enqueue(pair);
                    }
                    else
                    {
                        lats.Enqueue(pair);
                    }
                    isLong = !isLong;
                }

                placemark = new Placemark();
                line = new LineString();
                vectors = new List<Vector>();
                //pointPlacemarks = new List<Placemark>();
                //folder = new Folder() { Name = place };
                Vector vector = new Vector();
                (string original, double done) lat, lon;
                while (lons.Count > 0)
                {
                    lat = lats.Dequeue();
                    lon = lons.Dequeue();
                    vector = new Vector(lat.done, lon.done);
                    vectors.Add(vector);
                    //folder.AddFeature(new Placemark()
                    //{
                    //    Geometry = new Point() { Coordinate = vector },
                    //    Description = new Description() { Text = $"{lon.original}, {lat.original}" }
                    //});
                    //pointPlacemarks.Add();
                }
                //if (!vectors.First().Equals(vectors.Last()))
                //{
                //    vectors.Add(vectors.First());
                //}
                line.Coordinates = new CoordinateCollection(vectors);
                placemark.Geometry = line;
                placemark.Name = place;
                _currParent.Nodes.Add(place);
                //folder.AddFeature(placemark);
                _placemarks.Enqueue(placemark);
                //_folders.Enqueue(folder);
            }
            UpdateTreeNodeItemCount();
            SynchronizationContext context = SynchronizationContext.Current;
            label5.Visible = true;
            Task.Run(() =>
            {
                Thread.Sleep(5000);
                context.Post(o => label5.Visible = false, null);
            });
        }

        private void buttonCreateFolder_Click(object sender, EventArgs e)
        {
            Folder folder = new Folder();
            while (_placemarks.Count > 0)
            {
                folder.AddFeature(_placemarks.Dequeue());
            }
            FormCityOrCountyName form = new FormCityOrCountyName();
            if (form.ShowDialog() == DialogResult.OK)
            {
                folder.Name = form.CityName;
                _currParent.Text = form.CityName;
            }
            _cityFolders.Enqueue(folder);
            label6.Visible = true;
            SynchronizationContext context = SynchronizationContext.Current;
            Task.Run(() =>
            {
                Thread.Sleep(5000);
                context.Post(o => label6.Visible = false, null);
            });
            UpdateTreeNodeItemCount();
            _currParent = treeView1.Nodes.Add("Node");
        }

        void UpdateTreeNodeItemCount()
        {
            Regex rgx = new Regex("\\(\\d+\\)");
            string s = _currParent.Text;
            _currParent.Text = rgx.IsMatch(s) ? rgx.Replace(s, $"({_currParent.Nodes.Count})") : $"{s}({_currParent.Nodes.Count})";
        }

        private void button2KMZ_Click(object sender, EventArgs e)
        {
            Kml kml = new Kml();
            Folder folder = new Folder();
            while (_cityFolders.Count > 0)
            {
                folder.AddFeature(_cityFolders.Dequeue());
            }
            kml.Feature = folder;

            /* to see if the format is correct */
            //var serializer = new Serializer();
            //serializer.Serialize(kml);

            KmlFile kmlFile = KmlFile.Create(kml, false);
            using (KmzFile kmz = KmzFile.Create(kmlFile))
            {
                var links = new LinkResolver(kmlFile);
                foreach (string path in links.GetRelativePaths())
                {
                    if (path.StartsWith("..", StringComparison.Ordinal))
                    {
                        continue;
                    }
                    string fullPath = Path.Combine(Directory.GetCurrentDirectory(), path);
                    using (var file = File.OpenRead(fullPath))
                    {
                        kmz.AddFile(path, file);
                    }
                }
                using (Stream output = File.Create(Path.Combine(textBoxPath.Text, textBoxFileName.Text + ".kmz")))
                {
                    kmz.Save(output);
                }
            }
            label7.Visible = true;
            SynchronizationContext context = SynchronizationContext.Current;
            Task.Run(() =>
            {
                Thread.Sleep(5000);
                context.Post(o => label7.Visible = false, null);
            });
        }

        public string[] SeperateString(string s)
        {
            Regex rgx = new Regex("^\"|\\s*\"\\s*$|");
            s = rgx.Replace(s, "");
            rgx = new Regex(@"""\s*""(\d+(.\d+)*, {0,1}\d+(.\d+)*;)");
            s = rgx.Replace(s, "\r\n$1");
            rgx = new Regex("\"\\s*\"");
            return rgx.Split(s);
        }
        public string Test(string s)
        {
            Regex rgx = new Regex(@"""\s*""(\d+(.\d+)*, {0,1}\d+(.\d+)*;)");//\"\\s*\"\\(\\?<addr>\\d+(.\\d+)*, {0,1}\\d+(.\\d+)*;\\)
            return rgx.Replace(s, "$1");
        }

        public string[] SeperateTitleAndData(string s)
        {
            Regex rgx = new Regex(@"\d+(.\d+)*, {0,1}\d+(.\d+)*;");
            int index = rgx.Match(s).Index;
            rgx = new Regex("\\s");
            return new string[] { rgx.Replace(s.Substring(0, index), ""), s.Substring(index) };
        }

        private void buttonChoosePath_Click(object sender, EventArgs e)
        {
            using (var dialog = new CommonOpenFileDialog() { IsFolderPicker = true })
            {
                if (dialog.ShowDialog() == CommonFileDialogResult.Ok)
                {
                    textBoxPath.Text = dialog.FileName;
                }
            }
        }
        Queue<(string, string)> _latLongs = new Queue<(string, string)>();
        private void listView1_MouseDown(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Right)
            {
                string s = Clipboard.GetText();
                string[] placesAndLanLongs = SeperateString(s);
                string[] data;
                _latLongs.Clear();
                listView1.Items.Clear();
                foreach (string placeAndLanLong in placesAndLanLongs)
                {
                    data = SeperateTitleAndData(placeAndLanLong);
                    listView1.Items.Add(data[0]);
                    _latLongs.Enqueue((data[0], data[1]));
                }
                //Regex regex = new Regex(@"([^\d,\.;].*[^\d,\.;])");
                //var a = regex.Matches(s);
                //StringBuilder sb = new StringBuilder();
                //foreach(var n in a)
                //{
                //    sb.Append(n);
                //}
                //richTextBox1.Text = sb.ToString();

            }
        }
    }
}
