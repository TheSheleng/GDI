using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _9._6._2023
{
    public partial class MainForm : Form
    {
        const int cellSize = 100;
        const int cellCount = 8;
        const int playmentPading = 50;
        const int borderPading = 40;

        public MainForm()
        {
            InitializeComponent();

            int FormSize = cellSize * cellCount + playmentPading * 2;
            Size = new System.Drawing.Size(FormSize + 22, FormSize + 56);
        }

        private void MainForm_Paint(object sender, PaintEventArgs e)
        {
            Graphics g = e.Graphics;

            Pen pen = new Pen(Color.Black , 10);
            g.DrawRectangle(pen,
                borderPading,
                borderPading, 
                cellSize * cellCount + (playmentPading - borderPading) * 2, 
                cellSize * cellCount + (playmentPading - borderPading) * 2);
            pen.Dispose();

            SolidBrush brush = new SolidBrush(Color.Black);
            for (int y = 0; y < cellCount; y++)
                for (int x = y % 2; x < cellCount; x += 2)
                {
                    g.FillRectangle(brush,
                        playmentPading + x * cellSize,
                        playmentPading + y * cellSize,
                        cellSize, cellSize);
                }
            brush.Dispose();
        }
    }
}
