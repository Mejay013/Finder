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
using System.Security.Cryptography;

namespace TestExamLab
{
    class Provodnic
    {

        
        public string removeBackSlash(string path)
        {
            if (path.LastIndexOf("/") == path.Length - 1)
            {
                path = path.Substring(0, path.Length - 1);
                if (path == "Y:")
                {
                    path = "Y:/";
                }
            }
            return path;
        }

        public class Files
        {
            [PrimaryKey, AutoIncrement]
            public int ID { get; set; }
            public string filename { get; set; }
            public string path { get; set; }
            public string hash { get; set; }
            public string date_reload_hash { get; set; }
        }

        public void copy_file(string base_dir, string tempFilePath)
        {
            
            string new_dir = base_dir + "_copy";

            if (!Directory.Exists(new_dir))
            {
                Directory.CreateDirectory(new_dir);
            }
            string new_file = Path.GetFileName(tempFilePath);
            string new_file_path = Path.Combine(new_dir, Path.GetFileName(new_file));
            if (!File.Exists(new_file_path))
            {
                File.Copy(tempFilePath, new_file_path);
                insert_to_db(new_file, new_file_path);
            }
            else
            {
                check_hash(new_file_path, new_file);
            }
            
        }
        public void check_hash_folder(string folder_path)
        {
            DateTime date = DateTime.Today;

            foreach (var file in Directory.EnumerateFiles(folder_path))
            {
                string hash = ComputeMD5Checksum(Path.Combine(folder_path, Path.GetFileName(file)));
                string name = Path.GetFileName(file);
                string path = folder_path;

                var x = new Files();
                x.filename = name;
                x.path = path;
                x.hash = hash;
                x.date_reload_hash = date.ToString();

                Form1.db.Insert(x);

            }
        }
        public void check_folder_changed(string folder_path)
        {
            foreach (var file in Directory.EnumerateFiles(folder_path))
            {
                string checked_path = Path.Combine(folder_path, Path.GetFileName(file));
                string chech_path = Path.Combine(folder_path + "_copy", Path.GetFileName(file));
                string hash = ComputeMD5Checksum(checked_path);
                string hash_checked = ComputeMD5Checksum(chech_path);
                Form1.laInfinity.Text = "Отслеживается";
                if (!(hash == hash_checked))
                {
                    Form1.laChanged.Text = "Изменено";
                    Form1.laChanged.ForeColor = Color.Red;
                    var result = MessageBox.Show("В проверяемой папке были найдены изменения,принять изменения?",
                        "Обнаружены изменения", MessageBoxButtons.YesNo);
                    if (result == DialogResult.No)
                    {
                        File.Delete(checked_path);
                        File.Copy(chech_path, checked_path);
                    }
                    else
                    {
                        File.Delete(chech_path);
                        File.Copy(checked_path, chech_path);
                
                        foreach (var item in Form1.db.Table<Files>())
                        {
                            if (item.filename == Path.GetFileName(file) || item.path == Path.GetFullPath(file))
                            {
                                
                                item.hash = hash;
                                Form1.db.Delete(item);

                                Form1.db.Insert(item);
                            }
                        }
                    }
                    break;

                    }
                else
                {
                    continue;
                }
               
            }
            Form1.laChanged.Text = "Без изменений";
            Form1.laChanged.ForeColor = Color.Green;
        }
        public void check_hash(string new_file_path, string new_file)
        {
            string checked_file = ComputeMD5Checksum(new_file_path);
            foreach (var item in Form1.db.Table<Files>())
            {
                if (item.filename == new_file || item.path == new_file_path)
                {
                    Form1.laInfinity.Text = "Отслеживается";
                    if (item.hash == checked_file)
                    {
                        Form1.laChanged.Text = "Без изменений";
                        Form1.laChanged.ForeColor = Color.Green;
                        break;
                    }
                    else
                    {
                        Form1.laChanged.Text = "Изменено";
                        Form1.laChanged.ForeColor = Color.Red;
                        break;
                    }
                }
                else
                {
                    Form1.laInfinity.Text = "Не отслеживается";
                    Form1.laChanged.Text = "—";
                    Form1.laChanged.ForeColor = Color.Black;
                }
            }
        }
        public  void insert_to_db(string filename, string path)
        {
            DateTime date = DateTime.Today;

            var x = new Files();
            x.filename = filename;
            x.path = path;
            x.hash = ComputeMD5Checksum(path);
            x.date_reload_hash = date.ToString();

            Form1.db.Insert(x);
        }

        public string ComputeMD5Checksum(string path)
        {
            using (FileStream fs = System.IO.File.OpenRead(path))
            {
                MD5 md5 = new MD5CryptoServiceProvider();
                byte[] fileData = new byte[fs.Length];
                fs.Read(fileData, 0, (int)fs.Length);
                byte[] checkSum = md5.ComputeHash(fileData);
                string result = BitConverter.ToString(checkSum).Replace("-", String.Empty);
                return result;
            }
        }
        public long DirSize(DirectoryInfo d)
        {
            long size = 0;
            // Add file sizes.
            FileInfo[] fis = d.GetFiles();
            foreach (FileInfo fi in fis)
            {
                size += fi.Length;
            }
            
            return size;
        }
        public async void Copy_folder(string parent_path, string target_path)
        {
            if (!Directory.Exists(target_path))
            {
                Directory.CreateDirectory(target_path);

                foreach (var file in Directory.GetFiles(parent_path))
                    File.Copy(file, Path.Combine(target_path, Path.GetFileName(file)));

                foreach (var directory in Directory.GetDirectories(parent_path))
                    Copy_folder(directory, Path.Combine(target_path, Path.GetFileName(directory)));
            }
            else
            {
                foreach (var file in Directory.GetFiles(parent_path))
                    

                foreach (var directory in Directory.GetDirectories(parent_path))
                    Copy_folder(directory, Path.Combine(target_path, Path.GetFileName(directory)));
            }

          
        }

        public int FileTypes(string fileExtension)
        {
            int imageIndex;
            switch (fileExtension)
            {
                case ".MP3":
                case ".MP2":
                    imageIndex = 5;
                    return imageIndex;
                case ".EXE":
                case ".COM":
                    imageIndex = 2;
                    return imageIndex;
                case ".MP4":
                case ".AVI":
                case ".MKV":
                    imageIndex = 5;
                    return imageIndex;
                case ".DOC":
                case ".DOCX":
                    imageIndex = 1;
                    return imageIndex;
                case ".PNG":
                case ".JPG":
                case ".JPEG":
                    imageIndex = 4;
                    return imageIndex;
                default:
                    imageIndex = 0;
                    return imageIndex;


            }
        }
    }
}
