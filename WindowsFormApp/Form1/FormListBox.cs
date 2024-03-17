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
    public partial class FormListBox : Form
    {
        public FormListBox()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void FormListBox_Load(object sender, EventArgs e)
        {
            listBox1.Items.Add("Monday");
            listBox1.Items.Add("Teusday");
            listBox1.Items.Add("Wednesday");
            listBox1.Items.Add("Thursday");
            listBox1.Items.Add("Friday");
            listBox1.Items.Add("Saturday");
        }

        private void button1_Click(object sender, EventArgs e)
        {
            /*foreach(object obj in listBox1.SelectedItems)
            {
                MessageBox.Show(obj.ToString());
            }*/
            string items = " ";
            foreach(var item in listBox1.Items)
            {
                items += item.ToString() + ",";
            }
            MessageBox.Show(items);
        }
    }
}
