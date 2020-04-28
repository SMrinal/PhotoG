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

namespace PhotoG
{
    public partial class Form2 : Form
    {
        public static string source;
        string sourcedir = source;
        string sourcedir1;
        string dest;
        string name;
        string dest_1;
        string dest_2;
        public static string A;
        public static string B;
        public static string C;
        public static string D;
        public static string E;
        public static string F;
        public static string G;
        public static string H;
        public static string I;
        public static string J;
        public static string K;
        public static string L;
        public static string M;
        public static string N;
        public static string O;
        public static string P;
        public static string Q;
        public static string R;
        public static string S;
        public static string T;
        public static string U;
        public static string V;
        public static string W;
        public static string X;
        public static string Y;
        public static string Z;
        public static string num1;
        public static string A1;
        public static string B1;
        public static string C1;
        public static string D1;
        public static string E1;
        public static string F1;
        public static string G1;
        public static string H1;
        public static string I1;
        public static string J1;
        public static string K1;
        public static string L1;
        public static string M1;
        public static string N1;
        public static string O1;
        public static string P1;
        public static string Q1;
        public static string R1;
        public static string S1;
        public static string T1;
        public static string U1;
        public static string V1;
        public static string W1;
        public static string X1;
        public static string Y1;
        public static string Z1;
        public static string num_1;
        public static string A2;
        public static string B2;
        public static string C2;
        public static string D2;
        public static string E2;
        public static string F2;
        public static string G2;
        public static string H2;
        public static string I2;
        public static string J2;
        public static string K2;
        public static string L2;
        public static string M2;
        public static string N2;
        public static string O2;
        public static string P2;
        public static string Q2;
        public static string R2;
        public static string S2;
        public static string T2;
        public static string U2;
        public static string V2;
        public static string W2;
        public static string X2;
        public static string Y2;
        public static string Z2;
        public static string num__1;
       


        public Form2()
        {
            InitializeComponent();
        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                var selectedImage = listBox1.SelectedItems[0].ToString();
                name = selectedImage;





                if (!string.IsNullOrEmpty(selectedImage) && !string.IsNullOrEmpty(sourcedir))
                {
                    var fullPath = Path.Combine(sourcedir, selectedImage);
                    pictureBox1.Image = Image.FromFile(fullPath);
                    sourcedir1 = fullPath;







                }

            }
            catch (Exception)
            {
                throw;
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                var f = new FolderBrowserDialog();
                if (f.ShowDialog() == System.Windows.Forms.DialogResult.OK)
                {
                    listBox1.Items.Clear();
                    sourcedir = f.SelectedPath;
                    textBox1.Text = sourcedir;

                    var dirInfo = new DirectoryInfo(sourcedir);
                    var files = dirInfo.GetFiles().Where(c => c.Extension.Equals(".jpg") || c.Extension.Equals(".png") || c.Extension.Equals(".jpeg") || c.Extension.Equals(".bmp"));
                    foreach (var img in files)
                    {
                        listBox1.Items.Add(img.Name);
                    }


                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("There was an error:" + ex.Message + " " + ex.Source);


            }
        }

        private void Form2_Load(object sender, EventArgs e)
        {
            textBox1.Text = sourcedir;
            var dirInfo = new DirectoryInfo(sourcedir);
            var files = dirInfo.GetFiles().Where(c => c.Extension.Equals(".jpg") || c.Extension.Equals(".png") || c.Extension.Equals(".jpeg") || c.Extension.Equals(".bmp") || c.Extension.Equals(".JPG"));
            foreach (var img in files)
            {
                listBox1.Items.Add(img.Name);
            }


        }
        void organize()
        {
            try
            {
                var destdir = Path.Combine(dest, name);
                File.Copy(sourcedir1, destdir);

            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
                Form3 frm = new Form3();
                frm.Show();



            }


        }
        void organize_1()
        {
            try
            {
                var destdir = Path.Combine(dest_1, name);
                File.Copy(sourcedir1, destdir);

            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
                Form3 frm = new Form3();
                frm.Show();



            }
        }
            void organize_2()
        {
            try
            {
                var destdir = Path.Combine(dest_2, name);
                File.Copy(sourcedir1, destdir);

            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
                Form3 frm = new Form3();
                frm.Show();



            }
            
        }
        private void button3_Click(object sender, EventArgs e)
        {
            {
                var f = new FolderBrowserDialog();
                if (f.ShowDialog() == System.Windows.Forms.DialogResult.OK)
                {
                    dest = f.SelectedPath;
                    textBox2.Text = dest;

                }



            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            button2.Focus();
            A = "";
            B = "";
            C = "";
            D = "";
            E = "";
            F = "";
            G = "";
            H = "";
            I = "";
            J = "";
            K = "";
            L = "";
            M = "";
            N = "";
            O = "";
            P = "";
            Q = "";
            R = "";
            S = "";
            T = "";
            U = "";
            V = "";
            W = "";
            X = "";
            Y = "";
            Z = "";
            num1 = "";


        }

        private void Form2_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.A && A == "A")
            {
                organize();
            }
            if (e.KeyCode == Keys.B && B == "B")
            {
                organize();
            } if (e.KeyCode == Keys.C && C == "C")
            {
                organize();
            } if (e.KeyCode == Keys.D && D == "D")
            {
                organize();
            } if (e.KeyCode == Keys.E && E == "E")
            {
                organize();
            } if (e.KeyCode == Keys.F && F == "F")
            {
                organize();
            } if (e.KeyCode == Keys.G && G == "G")
            {
                organize();
            } if (e.KeyCode == Keys.H && H == "H")
            {
                organize();
            } if (e.KeyCode == Keys.I && I == "I")
            {
                organize();
            } if (e.KeyCode == Keys.J && J == "J")
            {
                organize();
            } if (e.KeyCode == Keys.K && K == "K")
            {
                organize();
            } if (e.KeyCode == Keys.L && L == "L")
            {
                organize();
            } if (e.KeyCode == Keys.M && M == "M")
            {
                organize();
            } if (e.KeyCode == Keys.N && N == "N")
            {
                organize();
            } if (e.KeyCode == Keys.O && O == "O")
            {
                organize();
            } if (e.KeyCode == Keys.P && P == "P")
            {
                organize();
            } if (e.KeyCode == Keys.Q && Q == "Q")
            {
                organize();
            } if (e.KeyCode == Keys.R && R == "R")
            {
                organize();
            } if (e.KeyCode == Keys.S && S == "S")
            {
                organize();
            } if (e.KeyCode == Keys.T && T == "T")
            {
                organize();
            } if (e.KeyCode == Keys.U && U == "U")
            {
                organize();
            } if (e.KeyCode == Keys.V && V == "V")
            {
                organize();
            } if (e.KeyCode == Keys.W && W == "W")
            {
                organize();
            } if (e.KeyCode == Keys.X && X == "X")
            {
                organize();
            } if (e.KeyCode == Keys.Y && Y == "Y")
            {
                organize();
            } if (e.KeyCode == Keys.Z && Z == "Z")
            {
                organize();
            } if (e.KeyCode == Keys.D1 && num1 == "1")
            {
                organize();
            }

            //second folder organiation

            if (e.KeyCode == Keys.A && A1 == "A")
            {
                organize_1();
            }
            if (e.KeyCode == Keys.B && B1 == "B")
            {
                organize_1();
            } if (e.KeyCode == Keys.C && C1 == "C")
            {
                organize_1();
            } if (e.KeyCode == Keys.D && D1 == "D")
            {
                organize_1();
            } if (e.KeyCode == Keys.E && E1 == "E")
            {
                organize_1();
            } if (e.KeyCode == Keys.F && F1 == "F")
            {
                organize_1();
            } if (e.KeyCode == Keys.G && G1 == "G")
            {
                organize_1();
            } if (e.KeyCode == Keys.H && H1 == "H")
            {
                organize_1();
            } if (e.KeyCode == Keys.I && I1 == "I")
            {
                organize_1();
            } if (e.KeyCode == Keys.J && J1 == "J")
            {
                organize_1();
            } if (e.KeyCode == Keys.K && K1 == "K")
            {
                organize_1();
            } if (e.KeyCode == Keys.L && L1 == "L")
            {
                organize_1();
            } if (e.KeyCode == Keys.M && M1 == "M")
            {
                organize_1();
            } if (e.KeyCode == Keys.N && N1 == "N")
            {
                organize_1();
            } if (e.KeyCode == Keys.O && O1 == "O")
            {
                organize_1();
            } if (e.KeyCode == Keys.P && P1 == "P")
            {
                organize_1();
            } if (e.KeyCode == Keys.Q && Q1 == "Q")
            {
                organize_1();
            } if (e.KeyCode == Keys.R && R1 == "R")
            {
                organize_1();
            } if (e.KeyCode == Keys.S && S1 == "S")
            {
                organize_1();
            } if (e.KeyCode == Keys.T && T1 == "T")
            {
                organize_1();
            } if (e.KeyCode == Keys.U && U1 == "U")
            {
                organize_1();
            } if (e.KeyCode == Keys.V && V1 == "V")
            {
                organize_1();
            } if (e.KeyCode == Keys.W && W1 == "W")
            {
                organize_1();
            } if (e.KeyCode == Keys.X && X1 == "X")
            {
                organize_1();
            } if (e.KeyCode == Keys.Y && Y1 == "Y")
            {
                organize_1();
            } if (e.KeyCode == Keys.Z && Z1 == "Z")
            {
                organize_1();
            } if (e.KeyCode == Keys.D1 && num_1 == "1")
            {
                organize_1();
            }
            if (e.KeyCode == Keys.A && A2 == "A")
            {
                organize_2();
            }
            if (e.KeyCode == Keys.B && B2 == "B")
            {
                organize_2();
            } 
            if (e.KeyCode == Keys.C && C2 == "C")
            {
                organize_2();
            }
            if (e.KeyCode == Keys.D && D2 == "D")
            {
                organize_2();
            } 
            if (e.KeyCode == Keys.E && E2 == "E")
            {
                organize_2();
            } 
            if (e.KeyCode == Keys.F && F2 == "F")
            {
                organize_2();
            } 
            if (e.KeyCode == Keys.G && G2 == "G")
            {
                organize_2();
            } 
            if (e.KeyCode == Keys.H && H2 == "H")
            {
                organize_2();
            } 
            if (e.KeyCode == Keys.I && I2 == "I")
            {
                organize_2();
            } 
            if (e.KeyCode == Keys.J && J2 == "J")
            {
                organize_2();
            } 
            if (e.KeyCode == Keys.K && K2 == "K")
            {
                organize_2();
            } 
            if (e.KeyCode == Keys.L && L2 == "L")
            {
                organize_2();
            } 
            if (e.KeyCode == Keys.M && M2 == "M")
            {
                organize_2();
            } 
            if (e.KeyCode == Keys.N && N2 == "N")
            {
                organize_2();
            } 
            if (e.KeyCode == Keys.O && O2 == "O")
            {
                organize_2();
            } 
            if (e.KeyCode == Keys.P && P2 == "P")
            {
                organize_2();
            } 
            if (e.KeyCode == Keys.Q && Q2 == "Q")
            {
                organize_2();
            } 
            if (e.KeyCode == Keys.R && R2 == "R")
            {
                organize_2();
            } 
            if (e.KeyCode == Keys.S && S2 == "S")
            {
                organize_2();
            } 
            if (e.KeyCode == Keys.T && T2 == "T")
            {
                organize_2();
            } 
            if (e.KeyCode == Keys.U && U2 == "U")
            {
                organize_2();
            } 
            if (e.KeyCode == Keys.V && V2 == "V")
            {
                organize_2();
            } 
            if (e.KeyCode == Keys.W && W2 == "W")
            {
                organize_2();
            } 
            if (e.KeyCode == Keys.X && X2 == "X")
            {
                organize_2();
            } 
            if (e.KeyCode == Keys.Y && Y2 == "Y")
            {
                organize_2();
            } 
            if (e.KeyCode == Keys.Z && Z2 == "Z")
            {
                organize_2();
            }
            if (e.KeyCode == Keys.D1 && num__1 == "1")
            {
                organize_2();
            }


        }

        private void button2_KeyDown(object sender, KeyEventArgs e)
        {
            if (button2.Focus() == true)
            {
                if (e.KeyCode == Keys.A && (A1 != "A") && (A2 != "A"))
                {
                    button2.Text = "A";
                    A = "A";
                }
                if (e.KeyCode == Keys.B && (B1 != "B" )&& (B2 != "B"))
                {
                    button2.Text = "B";
                    B = "B";
                }
                if (e.KeyCode == Keys.C && (C1 != "C") && (C2 != "C"))
                {
                    button2.Text = "C";
                    C = "C";
                }
                if (e.KeyCode == Keys.D && (D1 != "D") && (D2 != "D"))
                {
                    button2.Text = "D";
                    D = "D";
                }
                if (e.KeyCode == Keys.E &&( E1 != "E") && E2 != "E")
                {
                    button2.Text = "E";      
                    E = "E";
                }
                if (e.KeyCode == Keys.F &&( F1 != "F" )&& (F2 != "F"))
                {
                    button2.Text = "F";
                    F = "F";
                }
                if (e.KeyCode == Keys.G && (G1 != "G")&& (G2 != "G"))
                {
                    button2.Text = "G";
                    G = "G";
                }
                if (e.KeyCode == Keys.H && (H1 != "H") && (H2 != "H"))
                {
                    button2.Text = "H";
                    H = "H";
                }
                if (e.KeyCode == Keys.I && (I1 != "I") && (I2 != "I"))
                {
                    button2.Text = "I";
                    I = "I";
                }
                if (e.KeyCode == Keys.J && (J1 != "J") && (J2 != "J"))
                {
                    button2.Text = "J";
                    J = "J";
                }
                if (e.KeyCode == Keys.K && (K1 != "K") && (K2 != "K"))
                {
                    button2.Text = "K";
                    K = "K";
                }
                if (e.KeyCode == Keys.L && (L1 != "L") && (L2 != "L"))
                {
                    button2.Text = "L";
                    L = "L";
                }
                if (e.KeyCode == Keys.M && (M1 != "M") && (M2 != "M"))
                {
                    button2.Text = "M";
                    M = "M";
                }
                if (e.KeyCode == Keys.N && (N1 != "N") && (N2 != "N"))
                {
                    button2.Text = "N";
                    N = "N";
                }
                if (e.KeyCode == Keys.O && (O1 != "O") && (O2 != "O"))
                {
                    button2.Text = "O";
                    O = "O";
                }
                if (e.KeyCode == Keys.P && (P1 != "P") && (P2 != "P"))
                {
                    button2.Text = "P";
                    P = "P";
                }
                if (e.KeyCode == Keys.Q && (Q1 != "Q") && (Q2 != "Q"))
                {
                    button2.Text = "Q";
                    Q = "Q";
                }
                if (e.KeyCode == Keys.R && (R1 != "R")&& (R2 != "R"))
                {
                    button2.Text = "R";
                    R = "R";
                }
                if (e.KeyCode == Keys.S && (S1 != "S") && (S2 != "S"))
                {
                    button2.Text = "S";
                    S = "S";
                }
                if (e.KeyCode == Keys.T && (T1 != "T") && (T2 != "T"))
                {
                    button2.Text = "T";
                    T = "T";
                }
                if (e.KeyCode == Keys.U && (U1 != "U") && (U2 != "U"))
                {
                    button2.Text = "U";
                    U = "U";
                }
                if (e.KeyCode == Keys.V && (V1 != "V") && (V2 != "V"))
                {
                    button2.Text = "V";
                    V = "V";
                }
                if (e.KeyCode == Keys.W && (W1 != "W") && (W2 != "W"))
                {
                    button2.Text = "W";
                    W = "W";
                }
                if (e.KeyCode == Keys.X && (X1 != "X") && (X2 != "X"))
                {
                    button2.Text = "X";
                    X = "X";
                }
                if (e.KeyCode == Keys.Y && (Y1 != "Y")  && (Y2 != "Y"))
                {
                    button2.Text = "Y";
                    Y = "Y";
                }
                if (e.KeyCode == Keys.Z && (Z1 != "Z") && (Z2 != "Z"))
                {
                    button2.Text = "Z";
                    Z = "Z";
                }
                if (e.KeyCode == Keys.D1 && (num_1 != "1")  && (num__1 != "1"))
                {
                    button2.Text = "1";
                    num1 = "1";
                }

            }

        }

        private void button5_Click(object sender, EventArgs e)
        {
            button5.Focus();
            A1 = "";
            B1 = "";
            C1 = "";
            D1 = "";
            E1 = "";
            F1 = "";
            G1 = "";
            H1 = "";
            I1 = "";
            J1 = "";
            K1 = "";
            L1 = "";
            M1 = "";
            N1 = "";
            O1 = "";
            P1 = "";
            Q1 = "";
            R1 = "";
            S1 = "";
            T1 = "";
            U1 = "";
            V1 = "";
            W1 = "";
            X1 = "";
            Y1 = "";
            Z1 = "";
            num_1 = "";

        }

        private void button7_Click(object sender, EventArgs e)
        {
            button7.Focus();
            A2 = "";
            B2 = "";
            C2 = "";
            D2 = "";
            E2 = "";
            F2 = "";
            G2 = "";
            H2 = "";
            I2 = "";
            J2 = "";
            K2 = "";
            L2 = "";
            M2 = "";
            N2 = "";
            O2 = "";
            P2 = "";
            Q2 = "";
            R2 = "";
            S2 = "";
            T2 = "";
            U2 = "";
            V2 = "";
            W2 = "";
            X2 = "";
            Y2 = "";
            Z2 = "";
            num__1 = "";
        }

        private void button5_KeyDown(object sender, KeyEventArgs e)
        {

            if (button5.Focus() == true)
            {
                if (e.KeyCode == Keys.A && (A != "A") && (A2 != "A"))
                {
                    button5.Text = "A";
                    A1 = "A";
                }
                if (e.KeyCode == Keys.B && (B != "B") && (B2 != "B"))
                {
                    button5.Text = "B";
                    B1 = "B";
                }
                if (e.KeyCode == Keys.C && (C != "C") && (C2 != "C"))
                {
                    button5.Text = "C";
                    C1 = "C";
                }
                if (e.KeyCode == Keys.D && (D != "D") && (D2 != "D"))
                {
                    button5.Text = "D";
                    D1 = "D";
                }
                if (e.KeyCode == Keys.E && (E != "E") && (E2 != "E"))
                {
                    button5.Text = "E";
                    E1 = "E";
                }
                if (e.KeyCode == Keys.F && (F != "F") && (F2 != "F"))
                {
                    button5.Text = "F";
                    F1 = "F";
                }
                if (e.KeyCode == Keys.G && (G != "G") && (G2 != "G"))
                {
                    button5.Text = "G";
                    G1 = "G";
                }
                if (e.KeyCode == Keys.H && (H != "H") && (H2 != "H"))
                {
                    button5.Text = "H";
                    H1 = "H";
                }
                if (e.KeyCode == Keys.I && (I != "I") && (I2 != "I"))
                {
                    button5.Text = "I";
                    I1 = "I";
                }
                if (e.KeyCode == Keys.J && (J != "J") && (J2 != "J"))
                {
                    button5.Text = "J";
                    J1 = "J";
                }
                if (e.KeyCode == Keys.K && (K != "K") && (K2 != "K"))
                {
                    button5.Text = "K";
                    K1 = "K";
                }
                if (e.KeyCode == Keys.L && (L != "L") && (L2 != "L"))
                {
                    button5.Text = "L";
                    L1 = "L";
                }
                if (e.KeyCode == Keys.M && (M != "M") && (M2 != "M"))
                {
                    button5.Text = "M";
                    M1 = "M";
                }
                if (e.KeyCode == Keys.N && (N != "N") && (N2 != "N"))
                {
                    button5.Text = "N";
                    N1 = "N";
                }
                if (e.KeyCode == Keys.O && (O != "O") && (O2 != "O"))
                {
                    button5.Text = "O";
                    O1 = "O";
                }
                if (e.KeyCode == Keys.P && (P != "P") && (P2 != "P"))
                {
                    button5.Text = "P";
                    P1 = "P";
                }
                if (e.KeyCode == Keys.Q && (Q != "Q") && (Q2 != "Q"))
                {
                    button5.Text = "Q";
                    Q1 = "Q";
                }
                if (e.KeyCode == Keys.R && (R != "R") && (R2 != "R"))
                {
                    button5.Text = "R";
                    R1 = "R";
                }
                if (e.KeyCode == Keys.S && (S != "S") && (S2 != "S"))
                {
                    button5.Text = "S";
                    S1 = "S";
                }
                if (e.KeyCode == Keys.T && (T != "T") && (T2 != "T"))
                {
                    button5.Text = "T";
                    T1 = "T";
                }
                if (e.KeyCode == Keys.U && (U != "U") && (U2 != "U"))
                {
                    button5.Text = "U";
                    U1 = "U";
                }
                if (e.KeyCode == Keys.V && (V != "V") && (V2 != "V"))
                {
                    button5.Text = "V";
                    V1 = "V";
                }
                if (e.KeyCode == Keys.W && (W != "W") && (W2 != "W"))
                {
                    button5.Text = "W";
                    W1 = "W";
                }
                if (e.KeyCode == Keys.X && (X != "X") && (X2 != "X"))
                {
                    button5.Text = "X";
                    X1 = "X";
                }
                if (e.KeyCode == Keys.Y && (Y != "Y")&& (Y2 != "Y"))
                {
                    button5.Text = "Y";
                    Y1 = "Y";
                }
                if (e.KeyCode == Keys.Z && (Z != "Z") && (Z2 != "Z"))
                {
                    button5.Text = "Z";
                    Z1 = "Z";
                }
                if (e.KeyCode == Keys.D1 && (num1 != "1")&&(num__1 != "1"))
                {
                    button5.Text = "1";
                    num_1 = "1";
                }

            }


        }

        private void button4_Click(object sender, EventArgs e)
        {
            {
                var f = new FolderBrowserDialog();
                if (f.ShowDialog() == System.Windows.Forms.DialogResult.OK)
                {
                    dest_1 = f.SelectedPath;
                    textBox3.Text = dest_1;

                }



            }
        }

        private void button6_Click(object sender, EventArgs e)
        {
            {
                var f = new FolderBrowserDialog();
                if (f.ShowDialog() == System.Windows.Forms.DialogResult.OK)
                {
                    dest_2 = f.SelectedPath;
                    textBox4.Text = dest_2;

                }



            }

        }

        private void button7_KeyDown(object sender, KeyEventArgs e)
        {
            if (button7.Focus() == true)
            {
                if (e.KeyCode == Keys.A && (A != "A") && (A1 != "A"))
                {
                    button7.Text = "A";
                    A2 = "A";
                }
                if (e.KeyCode == Keys.B && (B != "B") && (B1 != "B"))
                {
                    button7.Text = "B";
                    B2 = "B";
                }
                if (e.KeyCode == Keys.C && (C != "C") && (C1 != "C"))
                {
                    button7.Text = "C";
                    C2 = "C";
                }
                if (e.KeyCode == Keys.D && (D != "D") && (D1 != "D"))
                {
                    button7.Text = "D";
                    D2 = "D";
                }
                if (e.KeyCode == Keys.E && (E != "E") && (E1 != "E"))
                {
                    button7.Text = "E";
                    E2 = "E";
                }
                if (e.KeyCode == Keys.F && (F != "F") && (F1 != "F"))
                {
                    button7.Text = "F";
                    F2 = "F";
                }
                if (e.KeyCode == Keys.G && (G != "G") && (G1 != "G"))
                {
                    button7.Text = "G";
                    G2 = "G";
                }
                if (e.KeyCode == Keys.H && (H != "H") && (H1 != "H"))
                {
                    button7.Text = "H";
                    H2 = "H";
                }
                if (e.KeyCode == Keys.I && (I != "I") && (I1 != "I"))
                {
                    button7.Text = "I";
                    I2 = "I";
                }
                if (e.KeyCode == Keys.J && (J != "J") && (J1 != "J"))
                {
                    button7.Text = "J";
                    J2 = "J";
                }
                if (e.KeyCode == Keys.K && (K != "K") && (K1 != "K"))
                {
                    button7.Text = "K";
                    K2 = "K";
                }
                if (e.KeyCode == Keys.L && (L != "L") && (L1 != "L"))
                {
                    button7.Text = "L";
                    L2 = "L";
                }
                if (e.KeyCode == Keys.M && (M != "M") && (M1 != "M"))
                {
                    button7.Text = "M";
                    M2 = "M";
                }
                if (e.KeyCode == Keys.N && (N != "N") && (N1 != "N"))
                {
                    button7.Text = "N";
                    N2 = "N";
                }
                if (e.KeyCode == Keys.O && (O != "O") && (O1 != "O"))
                {
                    button7.Text = "O";
                    O2 = "O";
                }
                if (e.KeyCode == Keys.P && (P != "P") && (P1 != "P"))
                {
                    button7.Text = "P";
                    P2 = "P";
                }
                if (e.KeyCode == Keys.Q && (Q != "Q") && (Q1 != "Q"))
                {
                    button7.Text = "Q";
                    Q2 = "Q";
                }
                if (e.KeyCode == Keys.R && (R != "R") && (R1 != "R"))
                {
                    button7.Text = "R";
                    R2 = "R";
                }
                if (e.KeyCode == Keys.S && (S != "S") && (S1 != "S"))
                {
                    button7.Text = "S";
                    S2 = "S";
                }
                if (e.KeyCode == Keys.T && (T != "T") && (T1 != "T"))
                {
                    button7.Text = "T";
                    T2 = "T";
                }
                if (e.KeyCode == Keys.U && (U != "U") && (U1 != "U"))
                {
                    button7.Text = "U";
                    U2 = "U";
                }
                if (e.KeyCode == Keys.V && (V != "V") && (V1 != "V"))
                {
                    button7.Text = "V";
                    V2 = "V";
                }
                if (e.KeyCode == Keys.W && (W != "W") && (W1 != "W"))
                {
                    button7.Text = "W";
                    W2 = "W";
                }
                if (e.KeyCode == Keys.X && (X != "X") && (X1 != "X"))
                {
                    button7.Text = "X";
                    X2 = "X";
                }
                if (e.KeyCode == Keys.Y && (Y != "Y") && (Y1 != "Y"))
                {
                    button7.Text = "Y";
                    Y2 = "Y";
                }
                if (e.KeyCode == Keys.Z && (Z != "Z") && (Z1 != "Z"))
                {
                    button7.Text = "Z";
                    Z2 = "Z";
                }

                if (e.KeyCode == Keys.D1 && (num1 != "1") && (num_1 != "1"))
                {
                    button7.Text = "1";
                    num__1 = "1";
                }


            }
        }



    }
}




