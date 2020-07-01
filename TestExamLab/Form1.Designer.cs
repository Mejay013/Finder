namespace TestExamLab
{
    partial class Form1
    {
        /// <summary>
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.listView1 = new System.Windows.Forms.ListView();
            this.iconList = new System.Windows.Forms.ImageList(this.components);
            this.buBack = new System.Windows.Forms.Button();
            this.buGo = new System.Windows.Forms.Button();
            this.tbFilePath = new System.Windows.Forms.TextBox();
            this.laFileName = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.laFileType = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.laCreationTime = new System.Windows.Forms.Label();
            this.prvios_imgage = new System.Windows.Forms.ImageList(this.components);
            this.lac = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.laAccessTime = new System.Windows.Forms.Label();
            Form1.laSizeFyle = new System.Windows.Forms.Label();
            this.buHome = new System.Windows.Forms.Button();
            this.buCheckChanges = new System.Windows.Forms.Button();
            Form1.laInfinity = new System.Windows.Forms.Label();
            Form1.laChanged = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // listView1
            // 
            this.listView1.HideSelection = false;
            this.listView1.LargeImageList = this.iconList;
            this.listView1.Location = new System.Drawing.Point(3, 40);
            this.listView1.Name = "listView1";
            this.listView1.Size = new System.Drawing.Size(628, 464);
            this.listView1.SmallImageList = this.iconList;
            this.listView1.TabIndex = 0;
            this.listView1.UseCompatibleStateImageBehavior = false;
            this.listView1.ItemSelectionChanged += new System.Windows.Forms.ListViewItemSelectionChangedEventHandler(this.listView1_ItemSelectionChanged);
            this.listView1.MouseClick += new System.Windows.Forms.MouseEventHandler(this.listView1_MouseClick);
            this.listView1.MouseDoubleClick += new System.Windows.Forms.MouseEventHandler(this.listView1_MouseDoubleClick);
            // 
            // iconList
            // 
            this.iconList.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("iconList.ImageStream")));
            this.iconList.TransparentColor = System.Drawing.Color.Transparent;
            this.iconList.Images.SetKeyName(0, "black-txt.png");
            this.iconList.Images.SetKeyName(1, "docx.png");
            this.iconList.Images.SetKeyName(2, "exe.png");
            this.iconList.Images.SetKeyName(3, "Folder-icon.png");
            this.iconList.Images.SetKeyName(4, "jpg.png");
            this.iconList.Images.SetKeyName(5, "mp3.png");
            this.iconList.Images.SetKeyName(6, "rar.png");
            this.iconList.Images.SetKeyName(7, "TestExamLab.png");
            // 
            // buBack
            // 
            this.buBack.Location = new System.Drawing.Point(12, 11);
            this.buBack.Name = "buBack";
            this.buBack.Size = new System.Drawing.Size(40, 23);
            this.buBack.TabIndex = 1;
            this.buBack.Text = "<";
            this.buBack.UseVisualStyleBackColor = true;
            this.buBack.Click += new System.EventHandler(this.buBack_Click);
            // 
            // buGo
            // 
            this.buGo.Location = new System.Drawing.Point(817, 12);
            this.buGo.Name = "buGo";
            this.buGo.Size = new System.Drawing.Size(75, 23);
            this.buGo.TabIndex = 2;
            this.buGo.Text = "Go";
            this.buGo.UseVisualStyleBackColor = true;
            this.buGo.Click += new System.EventHandler(this.buGo_Click);
            // 
            // tbFilePath
            // 
            this.tbFilePath.Location = new System.Drawing.Point(174, 14);
            this.tbFilePath.Name = "tbFilePath";
            this.tbFilePath.Size = new System.Drawing.Size(637, 20);
            this.tbFilePath.TabIndex = 3;
            // 
            // laFileName
            // 
            this.laFileName.AutoSize = true;
            this.laFileName.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.laFileName.Location = new System.Drawing.Point(641, 285);
            this.laFileName.Name = "laFileName";
            this.laFileName.Size = new System.Drawing.Size(21, 25);
            this.laFileName.TabIndex = 5;
            this.laFileName.Text = "—";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(657, 361);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(64, 13);
            this.label3.TabIndex = 6;
            this.label3.Text = "Тип файла:";
            // 
            // laFileType
            // 
            this.laFileType.AutoSize = true;
            this.laFileType.Location = new System.Drawing.Point(727, 361);
            this.laFileType.Name = "laFileType";
            this.laFileType.Size = new System.Drawing.Size(13, 13);
            this.laFileType.TabIndex = 7;
            this.laFileType.Text = "—";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(134, 17);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(34, 13);
            this.label2.TabIndex = 8;
            this.label2.Text = "Путь:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label4.Location = new System.Drawing.Point(637, 334);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(104, 17);
            this.label4.TabIndex = 9;
            this.label4.Text = "Информация";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(637, 321);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(247, 13);
            this.label5.TabIndex = 10;
            this.label5.Text = "————————————————————————————————————————";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Location = new System.Drawing.Point(646, 71);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(246, 196);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 11;
            this.pictureBox1.TabStop = false;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(637, 466);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(247, 13);
            this.label6.TabIndex = 12;
            this.label6.Text = "————————————————————————————————————————";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(659, 387);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(47, 13);
            this.label7.TabIndex = 13;
            this.label7.Text = "Создан:";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(656, 440);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(85, 13);
            this.label8.TabIndex = 14;
            this.label8.Text = "Отслеживание:";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(656, 453);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(68, 13);
            this.label9.TabIndex = 15;
            this.label9.Text = "Изменение:";
            // 
            // laCreationTime
            // 
            this.laCreationTime.AutoSize = true;
            this.laCreationTime.Location = new System.Drawing.Point(710, 387);
            this.laCreationTime.Name = "laCreationTime";
            this.laCreationTime.Size = new System.Drawing.Size(13, 13);
            this.laCreationTime.TabIndex = 16;
            this.laCreationTime.Text = "—";
            // 
            // prvios_imgage
            // 
            this.prvios_imgage.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("prvios_imgage.ImageStream")));
            this.prvios_imgage.TransparentColor = System.Drawing.Color.Transparent;
            this.prvios_imgage.Images.SetKeyName(0, "black-txt.png");
            this.prvios_imgage.Images.SetKeyName(1, "docx.png");
            this.prvios_imgage.Images.SetKeyName(2, "exe.png");
            this.prvios_imgage.Images.SetKeyName(3, "Folder-icon.png");
            this.prvios_imgage.Images.SetKeyName(4, "jpg.png");
            this.prvios_imgage.Images.SetKeyName(5, "mp3.png");
            this.prvios_imgage.Images.SetKeyName(6, "rar.png");
            this.prvios_imgage.Images.SetKeyName(7, "TestExamLab.png");
            // 
            // lac
            // 
            this.lac.AutoSize = true;
            this.lac.Location = new System.Drawing.Point(659, 400);
            this.lac.Name = "lac";
            this.lac.Size = new System.Drawing.Size(78, 13);
            this.lac.TabIndex = 19;
            this.lac.Text = "Использован:";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(659, 374);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(49, 13);
            this.label10.TabIndex = 20;
            this.label10.Text = "Размер:";
            // 
            // laAccessTime
            // 
            this.laAccessTime.AutoSize = true;
            this.laAccessTime.Location = new System.Drawing.Point(741, 400);
            this.laAccessTime.Name = "laAccessTime";
            this.laAccessTime.Size = new System.Drawing.Size(13, 13);
            this.laAccessTime.TabIndex = 21;
            this.laAccessTime.Text = "—";
            // 
            // laSizeFyle
            // 
            Form1.laSizeFyle.AutoSize = true;
            Form1.laSizeFyle.Location = new System.Drawing.Point(712, 374);
            Form1.laSizeFyle.Name = "laSizeFyle";
            Form1.laSizeFyle.Size = new System.Drawing.Size(13, 13);
            Form1.laSizeFyle.TabIndex = 22;
            Form1.laSizeFyle.Text = "—";
            // 
            // buHome
            // 
            this.buHome.Location = new System.Drawing.Point(58, 11);
            this.buHome.Name = "buHome";
            this.buHome.Size = new System.Drawing.Size(62, 23);
            this.buHome.TabIndex = 23;
            this.buHome.Text = "Home";
            this.buHome.UseVisualStyleBackColor = true;
            this.buHome.Click += new System.EventHandler(this.buHome_Click);
            // 
            // buCheckChanges
            // 
            this.buCheckChanges.Location = new System.Drawing.Point(646, 41);
            this.buCheckChanges.Name = "buCheckChanges";
            this.buCheckChanges.Size = new System.Drawing.Size(244, 24);
            this.buCheckChanges.TabIndex = 24;
            this.buCheckChanges.Text = "Проверить изменения";
            this.buCheckChanges.UseVisualStyleBackColor = true;
            this.buCheckChanges.Click += new System.EventHandler(this.buCheckChanges_Click);
            // 
            // laInfinity
            // 
            Form1.laInfinity.AutoSize = true;
            Form1.laInfinity.Location = new System.Drawing.Point(741, 440);
            Form1.laInfinity.Name = "laInfinity";
            Form1.laInfinity.Size = new System.Drawing.Size(13, 13);
            Form1.laInfinity.TabIndex = 25;
            Form1.laInfinity.Text = "—";
            // 
            // laChanged
            // 
            Form1.laChanged.AutoSize = true;
            Form1.laChanged.Location = new System.Drawing.Point(724, 453);
            Form1.laChanged.Name = "laChanged";
            Form1.laChanged.Size = new System.Drawing.Size(13, 13);
            Form1.laChanged.TabIndex = 26;
            Form1.laChanged.Text = "—";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(929, 505);
            this.Controls.Add(Form1.laChanged);
            this.Controls.Add(Form1.laInfinity);
            this.Controls.Add(this.buCheckChanges);
            this.Controls.Add(this.buHome);
            this.Controls.Add(Form1.laSizeFyle);
            this.Controls.Add(this.laAccessTime);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.lac);
            this.Controls.Add(this.laCreationTime);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.laFileType);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.laFileName);
            this.Controls.Add(this.tbFilePath);
            this.Controls.Add(this.buGo);
            this.Controls.Add(this.buBack);
            this.Controls.Add(this.listView1);
            this.MaximumSize = new System.Drawing.Size(945, 544);
            this.MinimumSize = new System.Drawing.Size(945, 544);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button buBack;
        private System.Windows.Forms.Button buGo;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        public System.Windows.Forms.ImageList iconList;
        private System.Windows.Forms.ListView listView1;
        private System.Windows.Forms.TextBox tbFilePath;
        private System.Windows.Forms.Label laFileName;
        private System.Windows.Forms.Label laFileType;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label laCreationTime;
        public System.Windows.Forms.ImageList prvios_imgage;
        private System.Windows.Forms.Label lac;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label laAccessTime;
        private System.Windows.Forms.Button buHome;
        private System.Windows.Forms.Button buCheckChanges;
        public static System.Windows.Forms.Label laSizeFyle;
        public static System.Windows.Forms.Label laInfinity;
        public static System.Windows.Forms.Label laChanged;
    }
}

