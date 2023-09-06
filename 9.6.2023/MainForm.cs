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
        const int figurePading = 20;
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

            Pen pen = new Pen(Color.Brown, 10);
            g.DrawRectangle(pen,
                borderPading,
                borderPading,
                cellSize * cellCount + (playmentPading - borderPading) * 2,
                cellSize * cellCount + (playmentPading - borderPading) * 2);
            pen.Dispose();

            SolidBrush brushBlack = new SolidBrush(Color.Black);
            SolidBrush brushWhite = new SolidBrush(Color.White);
            SolidBrush brushBoard = new SolidBrush(Color.Brown);
            for (int y = 0; y < cellCount; y++)
                for (int x = y % 2; x < cellCount; x += 2)
                {
                    g.FillRectangle(brushBoard,
                        playmentPading + x * cellSize,
                        playmentPading + y * cellSize,
                        cellSize, cellSize);
                }

            for (int y = 0; y < 3; y++)
                for (int x = 0; x < cellCount; x++)
                {
                    g.FillEllipse(brushBlack,
                        playmentPading + x * cellSize + figurePading / 2,
                        playmentPading + y * cellSize + figurePading / 2,
                        cellSize - figurePading, cellSize - figurePading);

                    g.FillEllipse(brushWhite,
                        playmentPading + x * cellSize + figurePading / 2,
                        playmentPading + (y + cellCount - 3) * cellSize + figurePading / 2,
                        cellSize - figurePading, cellSize - figurePading);
                }

            brushBlack.Dispose();
            brushWhite.Dispose();
            brushBoard.Dispose();
        }
    }
}
