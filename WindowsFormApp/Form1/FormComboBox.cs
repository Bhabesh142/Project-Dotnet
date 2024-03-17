using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Form1
{
    public partial class FormComboBox : Form
    {
        public FormComboBox()
        {
            InitializeComponent();
        }

        private void FormComboBox_Load(object sender, EventArgs e)
        {
            comboBox1.Items.Add("weekdays");
            comboBox1.Items.Add("year");
            comboBox1.Items.Add("month");
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            comboBox2.Items.Clear();
            if (comboBox1.SelectedItem == "weekdays")
            {
                comboBox2.Items.Add("Monday");
                comboBox2.Items.Add("Teusday");
                comboBox2.Items.Add("Wednesday");
                comboBox2.Items.Add("Thursday");
                comboBox2.Items.Add("Friday");
                comboBox2.Items.Add("Saturday");
                comboBox2.Items.Add("Sunday");
            }
            else if (comboBox1.SelectedItem == "year")
            {
                comboBox2.Items.Add("2000");
                comboBox2.Items.Add("2002");
                comboBox2.Items.Add("2004");
                comboBox2.Items.Add("2006");
                comboBox2.Items.Add("2008");
            }
            else if (comboBox1.SelectedItem == "month")
            {
                comboBox2.Items.Add("January");
                comboBox2.Items.Add("February");
                comboBox2.Items.Add("March");
                comboBox2.Items.Add("April");
                comboBox2.Items.Add("May");
                comboBox2.Items.Add("June");
            }

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
    }
}
