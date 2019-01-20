using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace ImageRotation
{
    public partial class ImageRotation : Form
    {
        string filename;
        string foldername;

        public ImageRotation()
        {
            InitializeComponent();
        }

        private Image imageLoad(string filepath)
        {
            string path = $"{foldername}\\{filepath}";
            try
            {
                this.filename = path;
                Image img = Image.FromFile(path);
                return img;
            }
            catch
            {
                //MessageBox.Show(path + " Not Find");
                return null;
            }
            
        }

        private void BTN_choose_folder_Click(object sender, EventArgs e)
        {
            FolderBrowserDialog fbd = new FolderBrowserDialog();
            fbd.RootFolder = Environment.SpecialFolder.Desktop;
            fbd.Description = "";
            fbd.ShowNewFolderButton = false;

            if(fbd.ShowDialog() == DialogResult.OK)
            {
                MessageBox.Show("กดปุ่ม save ได้เลย");
                this.foldername = fbd.SelectedPath;
            }

        }

        private void BTN_Save_Click(object sender, EventArgs e)
        {
            MessageBox.Show("รอแปปนะ จนกว่าจะมีข้อความขึ้นว่าเสร็จแล้ว");
            DirectoryInfo d = new DirectoryInfo(this.foldername);//Assuming Test is your Folder
            FileInfo[] Files = d.GetFiles("*.jpg"); //Getting Text files
            foreach (FileInfo file in Files)
            {
                //MessageBox.Show(file.Name);
                Image File = imageLoad(file.Name);

                string filenameTemp = this.filename.Remove(this.filename.Length - 4);

                File.RotateFlip(RotateFlipType.Rotate90FlipNone);
                File.Save(filenameTemp + "-1.jpg");

                File.RotateFlip(RotateFlipType.Rotate90FlipNone);
                File.Save(filenameTemp + "-2.jpg");

                File.RotateFlip(RotateFlipType.Rotate90FlipNone);
                File.Save(filenameTemp + "-3.jpg");
            }
            MessageBox.Show("เสร็จแล้วโว้ยยย...");
        }
    }
}
