using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.IO;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _13._9._2023__dz_
{
    public partial class MainForm : Form
    {
        [DllImport("user32.DLL", EntryPoint = "ReleaseCapture")]
        private extern static void ReleaseCapture();
        [DllImport("user32.DLL", EntryPoint = "SendMessage")]
        private extern static void SendMessage(IntPtr hWnd, int Msg, int wParam, int lParam);
        private void ChromPanel_MouseDown(object sender, MouseEventArgs e)
        {
            ReleaseCapture();
            SendMessage(Handle, 0x112, 0xF012, 0);
        }

        private void ChromMinimize_Click(object sender, EventArgs e)
        {
            WindowState = FormWindowState.Minimized;
        }

        private void ChromClose_Click(object sender, EventArgs e)
        {
            Close();
        }

        public MainForm()
        {
            InitializeComponent();

            GraphicsPath path = new GraphicsPath();

            float curveSize = 30;

            path.StartFigure();
            path.AddArc(0, 0, curveSize, curveSize, 180, 90);
            path.AddArc(Size.Width - curveSize, 0, curveSize, curveSize, 270, 90);
            path.AddArc(Size.Width - curveSize, Size.Height - curveSize, curveSize, curveSize, 0, 90);
            path.AddArc(0, Size.Height - curveSize, curveSize, curveSize, 90, 90);
            path.CloseFigure();

            this.Region = new Region(path);

            this.ChromMinimize.BackColor = this.BackColor;
        }
    }
}
