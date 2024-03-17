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
    public partial class Form5 : Form
    {
        public Form5()
        {
            InitializeComponent();
        }

        private void Form5_Load(object sender, EventArgs e)
        {
            pictureBox1.Image = Image.FromFile(@"C:\Users\hp\Pictures\Camera Roll\Kodaikanal.jpeg");
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            dateTimePicker1.Format = DateTimePickerFormat.Short;
            dateTimePicker1.Value = DateTime.Today;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int i;
            progressBar1.Minimum = 0;
            progressBar1.Maximum = 500;
            for (i = 0; i <= 500; i++)
            {
                progressBar1.Value = i;
            }
            DateTime var1;
            var1 = dateTimePicker1.Value;
            MessageBox.Show("The selected date is " + var1);
        }
    }
}
