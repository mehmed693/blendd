using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace blendd
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            Bitmap bmp = new Bitmap((int)(pictureBox1.Width * (this.CreateGraphics().DpiX + (this.CreateGraphics().DpiX / 24)) / 100), (int)(pictureBox1.Height * (this.CreateGraphics().DpiX + (this.CreateGraphics().DpiX / 24)) / 100));
            Graphics g = Graphics.FromImage(bmp);
            g.FillRectangle(Brushes.White, new Rectangle(0,0,bmp.Width, bmp.Height));
            pictureBox1.Image = bmp;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Bitmap bmp = new Bitmap(pictureBox1.Image);
            Graphics g = Graphics.FromImage(bmp);
            g.SmoothingMode = System.Drawing.Drawing2D.SmoothingMode.AntiAlias;
            g.DrawEllipse(Pens.Black, new Rectangle(0, 0, bmp.Width - 1, bmp.Height - 1));
            pictureBox1.Image = bmp;
        }
    }
}
