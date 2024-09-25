using Spire.Pdf;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PdfToXlsx
{
    public partial class FormPdfToExcel : Form
    {
        public FormPdfToExcel()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            FolderBrowserDialog dialog = new FolderBrowserDialog();
            dialog.ShowDialog();
            PdfDocument doc = new PdfDocument();
            doc.LoadFromFile(dialog.SelectedPath);
            doc.SaveToFile("test.xlsx",FileFormat.XLSX);
        }
    }
}
