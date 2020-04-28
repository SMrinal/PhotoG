using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PhotoG
{
    public partial class Form1 : Form
    {
        string currentDir = "";
        string path;
        public Form1()
        {
            InitializeComponent();
        }
        public static Image a;

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                var f = new FolderBrowserDialog();
                if (f.ShowDialog() == System.Windows.Forms.DialogResult.OK)
                {
                    listBoxImages.Items.Clear();
                    currentDir = f.SelectedPath;
                    path = currentDir;
                    textBoxDirectory.Text = currentDir;

                    var dirInfo = new DirectoryInfo(currentDir);
                    var files = dirInfo.GetFiles().Where(c => c.Extension.Equals(".jpg") || c.Extension.Equals(".png") || c.Extension.Equals(".jpeg") || c.Extension.Equals(".bmp")|| c.Extension.Equals(".JPG"));
                    foreach (var img in files)
                    {
                        listBoxImages.Items.Add(img.Name);
                    }


                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("There was an error:" + ex.Message + " " + ex.Source);


            }
        }

       

        private void listBoxImages_SelectedIndexChanged(object sender, EventArgs e)
        {


            try
            {
                var selectedImage = listBoxImages.SelectedItems[0].ToString();





                if (!string.IsNullOrEmpty(selectedImage) && !string.IsNullOrEmpty(currentDir))
                {
                    var fullPath = Path.Combine(currentDir, selectedImage);
                    pictureBoxImagePreview.Image = Image.FromFile(fullPath);
                    a = Image.FromFile(fullPath);







                }

            }
            catch (Exception)
            {
                throw;
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(currentDir))
            {
                Form4 f = new Form4();
                f.Show();
            }
            else
            {
                Fullscreen openForm = new Fullscreen();
                openForm.Show();
            }

        }

        private void button2_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.F5)
            {
                if (string.IsNullOrEmpty(currentDir))
                {
                    Form4 f = new Form4();
                    f.Show();
                }
                else
                {
                    Fullscreen openForm = new Fullscreen();
                    openForm.Show();
                }
            }
        }

        public int x { get; set; }

        private void button3_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(currentDir))
            {
                Form4 f = new Form4();
                f.Show();
            }
            else
            {
                Editor openForm2 = new Editor();
                openForm2.Show();
            }
        }

        private void pictureBoxImagePreview_Click(object sender, EventArgs e)
        {

        }

        private void button4_Click(object sender, EventArgs e)
        {
            if(string.IsNullOrEmpty(currentDir))
            {
                Form4 f = new Form4();
                f.Show();
            }
            else
            {
                Form2.source = path;
                Form2 frm = new Form2();
                frm.Show();

            }




        }

        private void button5_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(currentDir))
            {
                Form4 f = new Form4();
                f.Show();
            }
            else
            {
                Crop frm = new Crop();
                frm.Show();

            }
            
        }

        private void button6_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(currentDir))
            {
                Form4 f = new Form4();
                f.Show();
            }
            else
            {
                Form5 frm = new Form5();
                frm.Show();

            }
            
            
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
    }
}
    

