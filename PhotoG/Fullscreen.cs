using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PhotoG
{
    public partial class Fullscreen : Form
    {
        
        public Fullscreen()
        {
            InitializeComponent();
        }

        private void Fullscreen_Load(object sender, EventArgs e )
        {
            FormBorderStyle = FormBorderStyle.None;
            WindowState = FormWindowState.Maximized;
            TopMost = true;
            Fullscreen.ActiveForm.BackgroundImage = Form1.a;
            
            
         }

        private void Fullscreen_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Escape)
            {
                Visible = false;
            }
           
           
            
        }

      


        }
        
    }

