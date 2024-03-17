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
    public partial class Form3 : Form
    {
        public Form3()
        {
            InitializeComponent();
        }

        private void Form3_Load(object sender, EventArgs e)
        {
            this.Text = "Change from Properties Through Coding";
            this.BackColor = Color.Yellow;
            this.Size = new Size(550, 525);
            this.Location = new Point(100, 200);
            this.MaximizeBox = false;
        }

        private void label1_Click(object sender, EventArgs e)
        {
            this.Text = "My form with Label Event";
            label1.Text = "Label Event Generated";
            label1.Image = Image.FromFile(@"C:\Users\hp\Pictures\Camera Roll\Qantas.jpg");
        }
    }
}
