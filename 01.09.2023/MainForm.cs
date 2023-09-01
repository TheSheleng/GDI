using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _01._09._2023
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
        }

        private void button_Save_Click(object sender, EventArgs e)
        {
            Person person = new Person();

            person.Surname = textBox_Surname.Text;
            person.Name = textBox_Name.Text;
            person.Fatherland= textBox_Fatherland.Text;

            person.Gender = comboBox_Gender.Text;
            person.Date = dateTimePicker_Date.Text;

            Program.SavePerson(person);
        }

        private void button_Load_Click(object sender, EventArgs e)
        {
            Person person = Program.LoadPerson();

            textBox_Surname.Text = person.Surname;
            textBox_Name.Text = person.Name;
            textBox_Fatherland.Text = person.Fatherland;

            comboBox_Gender.Text = person.Gender;
            dateTimePicker_Date.Text = person.Date;
        }
    }
}
