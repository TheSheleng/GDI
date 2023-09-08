using Antlr.Runtime;
using NCalc;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Reflection.Emit;
using System.Text;
using System.Threading;
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

        bool isDrawing = false;

        private async void button1_Click(object sender, EventArgs e)
        {
            isDrawing = false;

            string input = textBox1.Text;
            int tb1 = trackBar1.Value;
            int tb2 = trackBar2.Value;

            Graphics g = pictureBox1.CreateGraphics();
            Pen pen = new Pen(Color.Black, 4);

            g.Clear(BackColor);

            await Task.Run(() => {
                isDrawing = true;

                try
                {
                    float step = tb2 / 100f;
                    for (float x = -250; x < 250; x += step)
                    {
                        Expression expr = new Expression(
                                input.Replace("X", $"({x.ToString().Replace(',', '.')})")
                            );

                        double result = Convert.ToDouble(expr.Evaluate());

                        g.DrawEllipse(pen, new RectangleF(
                            x * tb1 + 248,
                            -((float)result * tb1) + 248,
                            4, 4));

                        if (!isDrawing) return;
                    }
                }
                catch (Exception ex)
                {
                    Invoke((Action)(() => {
                        label2.Text = ex.Message;
                    }));
                }
            });

            pen.Dispose();
            g.Dispose();
        }
    }
}
