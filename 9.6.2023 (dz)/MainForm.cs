using Antlr.Runtime;
using NCalc;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _9._6._2023__dz_
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
        }

        private void draw()
        {
            string input = textBox1.Text;

            Graphics g = pictureBox1.CreateGraphics();
            Pen pen = new Pen(Color.Black, 4);

            g.Clear(BackColor);
            g.DrawLine(pen, 0, 252, 500, 252);
            g.DrawLine(pen, 252, 0, 252, 500);

            try
            {
                for (float x = -250; x < 250; x += 1f)
                {
                    Expression expr = new Expression(
                            input.Replace("X", $"({x.ToString().Replace(',', '.')})")
                        );

                    double result = Convert.ToDouble(expr.Evaluate());

                    g.DrawEllipse(pen, new RectangleF(
                        x * trackBar1.Value - 2 + 250, 
                        -((float)result * trackBar1.Value) - 2 + 250, 
                        4, 4));
                }
            }
            catch (Exception ex)
            {
                label2.Text = ex.Message;
            }

            pen.Dispose();
            g.Dispose();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            draw();
        }

        private void trackBar1_Scroll(object sender, EventArgs e)
        {
            draw();
        }
    }
}
