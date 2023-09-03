using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _1._09._2023__dz_
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
        }

        private void button_num_click(object sender, EventArgs e)
        {
            string ch = (sender as Button).Text;

            if (panel.Text == "0") panel.Text = ch;
            else panel.Text += ch;
        }

        private void button_act_click(object sender, EventArgs e)
        {
            if (sPanel.Text != "") button_equal_Click(null, null);

            sPanel.Text = panel.Text + (sender as Button).Text;
            panel.Text = "0";
        }

        private void button_wipe_click(object sender, EventArgs e)
        {
            if (panel.Text.Length <= 1) panel.Text = "0";
            else panel.Text = panel.Text.Remove(panel.Text.Length - 1);
        }

        private void button_dot_click(object sender, EventArgs e)
        {
            if (!panel.Text.Contains(',') && panel.Text.Length >= 1) panel.Text += ',';
        }

        private void button_ms_click(object sender, EventArgs e)
        {
            Program.Memory = panel.Text;
            button_mr.Enabled = true;
        }

        private void button_mr_click(object sender, EventArgs e)
        {
            panel.Text = Program.Memory;
        }

        private void button_equal_Click(object sender, EventArgs e)
        {
            if (sPanel.Text == "") return;

            float ansv = 0;

            switch (sPanel.Text[sPanel.Text.Length - 1])
            {
                case '+':
                    ansv = float.Parse(panel.Text) + float.Parse(sPanel.Text.Remove(sPanel.Text.Length - 1));
                    break;
                case '-':
                    ansv = float.Parse(panel.Text) - float.Parse(sPanel.Text.Remove(sPanel.Text.Length - 1));
                    break;
                case '*':
                    ansv = float.Parse(panel.Text) * float.Parse(sPanel.Text.Remove(sPanel.Text.Length - 1));
                    break;
                case '/':
                    ansv = float.Parse(panel.Text) / float.Parse(sPanel.Text.Remove(sPanel.Text.Length - 1));
                    break;
            }

            panel.Text = ansv.ToString();
            sPanel.Text = "";
        }

        private void button_c_click(object sender, EventArgs e)
        {
            panel.Text = "";
            sPanel.Text = "";
        }

        private void button_ce_click(object sender, EventArgs e)
        {
            sPanel.Text = "";
        }

        private void button_1dev_click(object sender, EventArgs e)
        {
            panel.Text = (1 / float.Parse(panel.Text)).ToString();
            sPanel.Text = "";
        }

        private void button_proc_click(object sender, EventArgs e)
        {
            panel.Text = (float.Parse(panel.Text) / 100).ToString();
            sPanel.Text = "";
        }
    }
}
