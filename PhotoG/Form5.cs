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
using System.Drawing.Imaging;

namespace PhotoG
{
    public partial class Form5 : Form
    {
        public static Image a;
        Image img;
        Bitmap bmp;
        public Form5()
        {
            InitializeComponent();
        }
       

        private void Form5_Load(object sender, EventArgs e)
        {
            try
            {
                img = Form1.a;
                Bitmap bit = new Bitmap(img);
                bmp = bit;
                pictureBox1.Image = bmp;
                a = pictureBox1.Image;

            }
            catch (Exception f)
            {
                Console.WriteLine(f.Message);
            }

        }

        private void button2_Click(object sender, EventArgs e)
        {
            if(bmp != null)
            {
                bmp.RotateFlip(RotateFlipType.Rotate90FlipXY);
                pictureBox1.Image = bmp;
            }
            
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (bmp != null)
            {
                bmp.RotateFlip(RotateFlipType.Rotate270FlipXY);
                pictureBox1.Image = bmp;
            }

        }

        private void pictureBox1_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            
        }

        private void button3_Click(object sender, EventArgs e)
        {
                SaveFileDialog sf = new SaveFileDialog();
                sf.Filter = "Images|*.jpeg;*.bmp;*.jpg*.png";
                ImageFormat format = ImageFormat.Jpeg;
                if (sf.ShowDialog() == System.Windows.Forms.DialogResult.OK)
                {
                    string ext = Path.GetExtension(sf.FileName);
                    switch(ext)
                    {
                        case ".jpg":
                            format = ImageFormat.Jpeg;
                            break;
                        case ".bmp":
                            format = ImageFormat.Bmp;
                            break;
                        case ".jpeg":
                            format = ImageFormat.Jpeg;
                            break;
                        case ".png":
                            format = ImageFormat.Png;
                            break;
                    }
                    pictureBox1.Image.Save(sf.FileName, format);

                }

        }

        private void button4_Click(object sender, EventArgs e)
        {
            {
                Form6 openForm = new Form6();
                openForm.Show();
            }

        }
    }
}
