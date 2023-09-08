using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _8._9._2023__dz_
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
            timer.Start();
        }

        private PointF FractionsInDegrees(int fract, int all)
        {
            double angle = fract * 360 * Math.PI / all / 180;
            return new PointF((float)Math.Sin(angle), (float)Math.Cos(angle));
        }

        private void timer_Tick(object sender, EventArgs e)
        {
            Graphics g = this.pictureBox.CreateGraphics();
            g.SmoothingMode = System.Drawing.Drawing2D.SmoothingMode.AntiAlias;

            pictureBox.Invalidate();
            pictureBox.Refresh();

            int height = this.pictureBox.Height;
            int width = this.pictureBox.Width;

            PointF center = new PointF(width / 2, height / 2);

            using (Pen pen = new Pen(Color.Black, 10))
                g.DrawEllipse(pen, 30, 30, width - 60, height - 60);

                TimeOnly time = TimeOnly.FromDateTime(DateTime.Now);
            PointF pHour = FractionsInDegrees(time.Hour, 12);
            PointF pMinute = FractionsInDegrees(time.Minute, 60);
            PointF pSecond = FractionsInDegrees(time.Second, 60);

            using (Pen pen = new Pen(Color.Black, 15))
                g.DrawLine(pen, center.X, center.Y, center.X + pHour.X * 180, center.Y - pHour.Y * 180);

            using (Pen pen = new Pen(Color.Black, 10))
                g.DrawLine(pen, center.X, center.Y, center.X + pMinute.X * 240, center.Y - pMinute.Y * 240);

            using (Pen pen = new Pen(Color.Red, 5))
                g.DrawLine(pen, center.X, center.Y, center.X + pSecond.X * 240, center.Y - pSecond.Y * 240);

            using (SolidBrush brush = new SolidBrush(Color.Black))
                g.FillEllipse(brush, center.X - 10, center.Y - 10, 20, 20);

            g.Dispose();
        }
    }
}
