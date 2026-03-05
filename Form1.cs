using System.Diagnostics;

namespace WinFormsApp3
{
    public partial class Form1 : Form
    {

        bool booleans = true;

        public Form1()
        {
            InitializeComponent();

            pictureBox1.MouseEnter += pictureBox1_MouseEnter;
            pictureBox1.MouseLeave += pictureBox1_MouseLeave;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Random rand = new Random();
            this.BackColor = Color.FromArgb(rand.Next(200), rand.Next(200), rand.Next(200));
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (booleans)
            {
                pictureBox1.Image = Properties.Resources.SW융합대학_로고;
                booleans = false;
            }
            else
            {
                pictureBox1.Image = Properties.Resources.화면_캡처_2026_03_05_165815;
                booleans = true;
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            ProcessStartInfo psi = new ProcessStartInfo
            {
                FileName = "https://github.com/Yangnyeom06/WinFormsAppNameCard",
                UseShellExecute = true
            };

            System.Diagnostics.Process.Start(psi);
        }

        private void pictureBox1_MouseEnter(object sender, EventArgs e)
        {
            pictureBox1.BorderStyle = BorderStyle.Fixed3D;
        }

        private void pictureBox1_MouseLeave(object sender, EventArgs e)
        {
            pictureBox1.BorderStyle = BorderStyle.None;
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }
    }
}