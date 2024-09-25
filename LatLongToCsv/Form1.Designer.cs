namespace PdfToXlsx
{
    partial class Form1
    {
        /// <summary>
        /// 設計工具所需的變數。
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 清除任何使用中的資源。
        /// </summary>
        /// <param name="disposing">如果應該處置受控資源則為 true，否則為 false。</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form 設計工具產生的程式碼

        /// <summary>
        /// 此為設計工具支援所需的方法 - 請勿使用程式碼編輯器修改
        /// 這個方法的內容。
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            System.Windows.Forms.TreeNode treeNode1 = new System.Windows.Forms.TreeNode("Node");
            this.textBoxFileName = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.textBoxPath = new System.Windows.Forms.TextBox();
            this.imageList1 = new System.Windows.Forms.ImageList(this.components);
            this.buttonChoosePath = new System.Windows.Forms.Button();
            this.button2KMZ = new System.Windows.Forms.Button();
            this.buttonAddPlacemark = new System.Windows.Forms.Button();
            this.buttonCreateFolder = new System.Windows.Forms.Button();
            this.listView1 = new System.Windows.Forms.ListView();
            this.label2 = new System.Windows.Forms.Label();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.checkBox1 = new System.Windows.Forms.CheckBox();
            this.treeView1 = new System.Windows.Forms.TreeView();
            this.SuspendLayout();
            // 
            // textBoxFileName
            // 
            this.textBoxFileName.Location = new System.Drawing.Point(136, 290);
            this.textBoxFileName.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.textBoxFileName.Name = "textBoxFileName";
            this.textBoxFileName.Size = new System.Drawing.Size(171, 27);
            this.textBoxFileName.TabIndex = 8;
            this.textBoxFileName.Text = "doc";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(27, 300);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(76, 19);
            this.label3.TabIndex = 9;
            this.label3.Text = "檔案名稱: ";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(27, 352);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(76, 19);
            this.label4.TabIndex = 10;
            this.label4.Text = "儲存路徑: ";
            // 
            // textBoxPath
            // 
            this.textBoxPath.Location = new System.Drawing.Point(136, 340);
            this.textBoxPath.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.textBoxPath.Name = "textBoxPath";
            this.textBoxPath.Size = new System.Drawing.Size(171, 27);
            this.textBoxPath.TabIndex = 11;
            // 
            // imageList1
            // 
            this.imageList1.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("imageList1.ImageStream")));
            this.imageList1.TransparentColor = System.Drawing.Color.Transparent;
            this.imageList1.Images.SetKeyName(0, "folder.png");
            // 
            // buttonChoosePath
            // 
            this.buttonChoosePath.ImageKey = "folder.png";
            this.buttonChoosePath.ImageList = this.imageList1;
            this.buttonChoosePath.Location = new System.Drawing.Point(313, 334);
            this.buttonChoosePath.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.buttonChoosePath.Name = "buttonChoosePath";
            this.buttonChoosePath.Size = new System.Drawing.Size(39, 37);
            this.buttonChoosePath.TabIndex = 12;
            this.buttonChoosePath.UseVisualStyleBackColor = true;
            this.buttonChoosePath.Click += new System.EventHandler(this.buttonChoosePath_Click);
            // 
            // button2KMZ
            // 
            this.button2KMZ.Location = new System.Drawing.Point(224, 192);
            this.button2KMZ.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.button2KMZ.Name = "button2KMZ";
            this.button2KMZ.Size = new System.Drawing.Size(83, 61);
            this.button2KMZ.TabIndex = 13;
            this.button2KMZ.Text = "to KMZ";
            this.button2KMZ.UseVisualStyleBackColor = true;
            this.button2KMZ.Click += new System.EventHandler(this.button2KMZ_Click);
            // 
            // buttonAddPlacemark
            // 
            this.buttonAddPlacemark.Location = new System.Drawing.Point(216, 13);
            this.buttonAddPlacemark.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.buttonAddPlacemark.Name = "buttonAddPlacemark";
            this.buttonAddPlacemark.Size = new System.Drawing.Size(91, 74);
            this.buttonAddPlacemark.TabIndex = 14;
            this.buttonAddPlacemark.Text = "add";
            this.buttonAddPlacemark.UseVisualStyleBackColor = true;
            this.buttonAddPlacemark.Click += new System.EventHandler(this.buttonAddPlacemark_Click);
            // 
            // buttonCreateFolder
            // 
            this.buttonCreateFolder.Location = new System.Drawing.Point(224, 95);
            this.buttonCreateFolder.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.buttonCreateFolder.Name = "buttonCreateFolder";
            this.buttonCreateFolder.Size = new System.Drawing.Size(83, 74);
            this.buttonCreateFolder.TabIndex = 16;
            this.buttonCreateFolder.Text = "wrap into a folder";
            this.buttonCreateFolder.UseVisualStyleBackColor = true;
            this.buttonCreateFolder.Click += new System.EventHandler(this.buttonCreateFolder_Click);
            // 
            // listView1
            // 
            this.listView1.HideSelection = false;
            this.listView1.Location = new System.Drawing.Point(31, 38);
            this.listView1.Name = "listView1";
            this.listView1.Size = new System.Drawing.Size(161, 202);
            this.listView1.TabIndex = 18;
            this.listView1.UseCompatibleStateImageBehavior = false;
            this.listView1.View = System.Windows.Forms.View.List;
            this.listView1.MouseDown += new System.Windows.Forms.MouseEventHandler(this.listView1_MouseDown);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(27, 397);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(99, 19);
            this.label2.TabIndex = 19;
            this.label2.Text = "忽略這些文字";
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(136, 394);
            this.textBox2.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.textBox2.Multiline = true;
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(232, 47);
            this.textBox2.TabIndex = 20;
            this.textBox2.Text = "順序連接下列各點所含之區域：\r\n";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.ForeColor = System.Drawing.Color.Green;
            this.label5.Location = new System.Drawing.Point(309, 41);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(24, 19);
            this.label5.TabIndex = 21;
            this.label5.Text = "✔️";
            this.label5.Visible = false;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.ForeColor = System.Drawing.Color.Green;
            this.label6.Location = new System.Drawing.Point(309, 123);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(24, 19);
            this.label6.TabIndex = 22;
            this.label6.Text = "✔️";
            this.label6.Visible = false;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.ForeColor = System.Drawing.Color.Green;
            this.label7.Location = new System.Drawing.Point(309, 221);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(24, 19);
            this.label7.TabIndex = 23;
            this.label7.Text = "✔️";
            this.label7.Visible = false;
            // 
            // checkBox1
            // 
            this.checkBox1.AutoSize = true;
            this.checkBox1.Checked = true;
            this.checkBox1.CheckState = System.Windows.Forms.CheckState.Checked;
            this.checkBox1.Location = new System.Drawing.Point(88, 9);
            this.checkBox1.Name = "checkBox1";
            this.checkBox1.Size = new System.Drawing.Size(91, 23);
            this.checkBox1.TabIndex = 24;
            this.checkBox1.Text = "連續輸入";
            this.checkBox1.UseVisualStyleBackColor = true;
            // 
            // treeView1
            // 
            this.treeView1.Location = new System.Drawing.Point(425, 13);
            this.treeView1.Name = "treeView1";
            treeNode1.Name = "Node1";
            treeNode1.Text = "Node";
            this.treeView1.Nodes.AddRange(new System.Windows.Forms.TreeNode[] {
            treeNode1});
            this.treeView1.Size = new System.Drawing.Size(208, 320);
            this.treeView1.TabIndex = 25;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 19F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(692, 476);
            this.Controls.Add(this.treeView1);
            this.Controls.Add(this.checkBox1);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.textBox2);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.listView1);
            this.Controls.Add(this.buttonCreateFolder);
            this.Controls.Add(this.buttonAddPlacemark);
            this.Controls.Add(this.button2KMZ);
            this.Controls.Add(this.buttonChoosePath);
            this.Controls.Add(this.textBoxPath);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.textBoxFileName);
            this.Controls.Add(this.label3);
            this.Font = new System.Drawing.Font("微軟正黑體", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.TextBox textBoxFileName;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox textBoxPath;
        private System.Windows.Forms.Button buttonChoosePath;
        private System.Windows.Forms.ImageList imageList1;
        private System.Windows.Forms.Button button2KMZ;
        private System.Windows.Forms.Button buttonAddPlacemark;
        private System.Windows.Forms.Button buttonCreateFolder;
        private System.Windows.Forms.ListView listView1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.CheckBox checkBox1;
        private System.Windows.Forms.TreeView treeView1;
    }
}

