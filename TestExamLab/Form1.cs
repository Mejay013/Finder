using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Diagnostics;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using SQLite;

namespace TestExamLab
{
    public partial class Form1 : Form
    {
        public static SQLiteConnection db;

        public string filePath = "Y:/";
        public bool isFile = false;
        private string currectlySelectedItemName = "";
        Provodnic prov = new Provodnic();

        BackgroundWorker bw;

        public Form1()
        {
            InitializeComponent();

            db = new SQLiteConnection("my_db.db");
            db.CreateTable<Provodnic.Files>();

            bw = new BackgroundWorker();

        }
        public void loadButtonAction(bool isFile, string filepath)
        {
            prov.removeBackSlash(filepath);
            loadFilesAndDirectories(isFile, filepath);
            isFile = false;
        }
        private void Form1_Load(object sender, EventArgs e)
        {

            tbFilePath.Text = filePath;
            loadFilesAndDirectories(isFile,filePath);

        }

        public void loadFilesAndDirectories(bool isFile, string filePath)
        {
            DirectoryInfo fileList;
            string tempFilePath = "";
            FileAttributes fileAttr;
            try
            {
                if (isFile)
                {
                    tempFilePath = filePath + "/" + currectlySelectedItemName;
                    fileAttr = File.GetAttributes(tempFilePath);
                    Process.Start(tempFilePath);
                }
                else
                {
                    fileAttr = File.GetAttributes(filePath);
                }
                if ((fileAttr & FileAttributes.Directory) == FileAttributes.Directory)
                {
                    fileList = new DirectoryInfo(filePath);
                    FileInfo[] files = fileList.GetFiles(); // передает все файлы
                    DirectoryInfo[] dirs = fileList.GetDirectories(); // передает все папки
                    string fileExtension = "";

                    listView1.Items.Clear();
                    for (int i = 0; i < files.Length; i++)
                    {
                        fileExtension = files[i].Extension.ToUpper();
                        int typefile = prov.FileTypes(fileExtension);
                        listView1.Items.Add(files[i].Name, typefile);

                    }
                    for (int i = 0; i < dirs.Length; i++)
                    {
                        listView1.Items.Add(dirs[i].Name, 3);
                    }
                }
                else
                {

                    laFileName.Text = this.currectlySelectedItemName;
                }
            }
            catch
            {

            }
        }
     
        public void goBack()
        {
            try
            {
                tbFilePath.Text = prov.removeBackSlash(filePath);
                string path = tbFilePath.Text;
                path = path.Substring(0, path.LastIndexOf("/"));
                this.isFile = false;
                tbFilePath.Text = path;
                tbFilePath.Text = prov.removeBackSlash(path);
            }
            catch (Exception)
            {
                throw;
            }
        }

        private void buGo_Click(object sender, EventArgs e)
        {
            filePath = tbFilePath.Text;
            loadButtonAction(isFile,filePath);
        }

        private void listView1_ItemSelectionChanged(object sender, ListViewItemSelectionChangedEventArgs e)
        {
            currectlySelectedItemName = e.Item.Text;

            FileAttributes fileAttr = File.GetAttributes(filePath + "/" + currectlySelectedItemName);
            if ((fileAttr & FileAttributes.Directory) == FileAttributes.Directory  )
            {
                isFile = false;
                tbFilePath.Text = filePath + "/" + currectlySelectedItemName;
            }
            else
            {
                isFile = true;
            }
        }

        private void listView1_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            filePath = tbFilePath.Text;
            loadButtonAction(isFile,filePath);
        }

        private void buBack_Click(object sender, EventArgs e)
        {
            goBack();
            filePath = tbFilePath.Text;
            loadButtonAction(isFile,filePath);
        }

         private void listView1_MouseClick(object sender, MouseEventArgs e)
        {
            int index_img;
            string tempFilePath = filePath + "/" + currectlySelectedItemName;
            Form1.laInfinity.Text = "-";
            Form1.laChanged.Text = "-";
            if (File.Exists(tempFilePath))
            {
                prov.check_hash(tempFilePath, Path.GetFileName(tempFilePath));
                FileInfo failDetails = new FileInfo(tempFilePath);
                laFileName.Text = failDetails.Name;
                string type_file = failDetails.Extension;
                if (type_file == ".jpg")
                {
                    index_img = 333;
                }
                else
                {
                    index_img = prov.FileTypes(failDetails.Extension.ToUpper());
                }
                laSizeFyle.Text = (failDetails.Length / 1024).ToString() + " КБ";
                laAccessTime.Text = failDetails.LastAccessTime.ToString();
                laCreationTime.Text = failDetails.CreationTime.ToString();
                setimages(index_img, tempFilePath);
            }
            else
            {

                DirectoryInfo failDetails = new DirectoryInfo(tempFilePath);
                laFileName.Text = failDetails.Name;
                laFileType.Text = "Dirrectory";
                laSizeFyle.Text = (prov.DirSize(failDetails) + " КБ ").ToString();
                laCreationTime.Text = failDetails.CreationTime.ToString();
                laAccessTime.Text = failDetails.LastAccessTime.ToString();
                index_img = 1;
                setimages(index_img,tempFilePath);
            }
            
                
        }

        private void setimages(int index_img, string tempFilePath)
        {
            if (index_img == 333)
            {
                pictureBox1.Image = Image.FromFile(tempFilePath);
            }
            else
            {
                pictureBox1.Image = prvios_imgage.Images[index_img];
            }
        }

        private void buHome_Click(object sender, EventArgs e)
        {
            loadButtonAction(isFile, "Y:/");
            tbFilePath.Text = "Y:/";
        }
        
        private void buCheckChanges_Click(object sender, EventArgs e)
        {
            
            string parent_path = tbFilePath.Text;
            string tempFilePath = filePath + "/" + currectlySelectedItemName;
            ListView.SelectedListViewItemCollection breakfast = this.listView1.SelectedItems;
            foreach(ListViewItem item in breakfast)
            {
                string target_path = parent_path + "_copy";

                DirectoryInfo di = new DirectoryInfo(target_path);
                if (File.Exists(tempFilePath))
                {
                    string base_dir = filePath;
                    prov.copy_file(base_dir,tempFilePath);
                }
        
                else
                {
                    if (!di.Exists)
                    {
                        laChanged.Text = "Архивирование";
                        laChanged.ForeColor = Color.Yellow;
                        bw.DoWork += (obj,ae) => prov.Copy_folder(parent_path, target_path);
                        bw.RunWorkerAsync();
                        prov.check_hash_folder(tempFilePath);
                        MessageBox.Show("Папка " + parent_path + " не отслеживалась раннее.Начало отслеживания!");
                        loadButtonAction(isFile, filePath);
                    }
                    else
                    {
                        prov.check_folder_changed(tempFilePath);
                    }
                    
                }
            }
        }
      
    }
}
