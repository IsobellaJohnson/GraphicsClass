using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GraphicsClass
{
    public partial class Form1 : Form
    {
        private Graphics graphics;
        private Font font;
        public Form1()
        {
            InitializeComponent();
            graphics = CreateGraphics();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            graphics.DrawLine(Pens.DeepPink, new Point(30, 10), new Point(100, 45));
        }

        private void button2_Click(object sender, EventArgs e)
        {
            graphics.DrawLine(Pens.DeepPink, new Point(30,45), new Point(100, 10));
        }

        private void button3_Click(object sender, EventArgs e)
        {
            graphics.FillRectangle(Brushes.DeepPink, new Rectangle(20, 100, 100, 50));
            graphics.DrawRectangle(Pens.HotPink, new Rectangle(20, 100, 100, 50));
        }

        private void button4_Click(object sender, EventArgs e)
        {
            graphics.FillEllipse(Brushes.Magenta, new RectangleF(75, 185, 240, 120));
            graphics.FillEllipse(Brushes.HotPink, new RectangleF(60, 180, 240, 120));
            
        }

        private void button5_Click(object sender, EventArgs e)
        {
            Font font = new Font("Consolas", 45, FontStyle.Italic);
            graphics.DrawString("Hello", font, Brushes.Plum, new Point(85, 185));
        }
    }
}
