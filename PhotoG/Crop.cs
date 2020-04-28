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
    public partial class Crop : Form
    {
        Image img;
        Rectangle Rect;
        Point LocationXY;
        Point LocationX1Y1;
        bool IsMouseDown = false;

        public Crop()
        {
            InitializeComponent();
        }

        private void Crop_Load(object sender, EventArgs e)
        {
            img = Form1.a;
            pictureBox1.Image = img;
            
            

        }

        private void pictureBox1_MouseDown(object sender, MouseEventArgs e)
        {
            try
            {
                IsMouseDown = true;
                LocationXY = e.Location;


            }
            catch (Exception f)
            {
                Console.WriteLine(f.Message);
                
                
            }
           

        }

        private void pictureBox1_MouseMove(object sender, MouseEventArgs e)
        {
            if (IsMouseDown == true)
            {
                LocationX1Y1 = e.Location;
                Refresh();

            }
        }

        private void pictureBox1_MouseUp(object sender, MouseEventArgs e)
        {
            if (IsMouseDown == true)
            {
                LocationX1Y1 = e.Location;
                IsMouseDown = false;
                

            }
        }

        private void pictureBox1_Paint(object sender, PaintEventArgs e)
        {
            if (Rect != null )
            {
                e.Graphics.DrawRectangle(Pens.Black, GetRect());
                
            }
        }
        private Rectangle GetRect()
        {
            Rect = new Rectangle();
            Rect.X = Math.Min(LocationXY.X, LocationX1Y1.X);
            Rect.Y = Math.Min(LocationXY.Y, LocationX1Y1.Y);
            Rect.Width = Math.Abs(LocationXY.X - LocationX1Y1.X);
            Rect.Height = Math.Abs(LocationXY.Y - LocationX1Y1.Y);
            return Rect;
            }

      
        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                if (Rect != null)
                {
                    Bitmap bit = new Bitmap(pictureBox1.Image, pictureBox1.Width, pictureBox1.Height);
                    Bitmap cropping = new Bitmap(Rect.Width, Rect.Height);
                    Graphics g = Graphics.FromImage(cropping);
                    g.DrawImage(bit, 0, 0, Rect, GraphicsUnit.Pixel);
                    pictureBox1.Image = cropping;
                }


            }
            catch (Exception f)
            {
                Console.WriteLine(f.Message);
                
                
            }
        }


        private void button1_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Z)
            {
                pictureBox1.Image = Form1.a;
            }


        }

        private void pictureBox1_MouseEnter(object sender, EventArgs e)
        {
            Cursor = Cursors.Cross;
        }

        private void pictureBox1_MouseLeave(object sender, EventArgs e)
        {
            Cursor = Cursors.Default;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            saveImage();

        }
        public void saveImage()
        {
            var opened = true;
            
            if (opened)
            {
                SaveFileDialog sf = new SaveFileDialog();
                sf.Filter = "Images|*.jpeg;*.bmp;*.jpg*.png";
                ImageFormat format = ImageFormat.Jpeg;
                if (sf.ShowDialog() == System.Windows.Forms.DialogResult.OK)
                {
                    string ext = Path.GetExtension(sf.FileName);
                    switch (ext)
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
        }

        private void pictureBox1_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            pictureBox1.Image = Form1.a;
        }


    }
}
