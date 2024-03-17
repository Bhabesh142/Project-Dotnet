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
    public partial class Form4 : Form
    {
        public Form4()
        {
            InitializeComponent();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            label1.Text = textBox1.Text;
        }

        private void Form4_Load(object sender, EventArgs e)
        {
            textBox1.Width = 100;
            textBox1.Height = 50;
            textBox1.BackColor = Color.Aqua;
            textBox1.ForeColor = Color.White;
            textBox1.BorderStyle = BorderStyle.Fixed3D;
            //textBox1.MaxLength = 4;
            textBox1.Multiline = true;
            //textBox1.ReadOnly = true;
            //textBox1.PasswordChar = '*';
            textBox1.Text = "Hello Bro";
            textBox1.Text += "Aeroplanes fly in sky";

        }

        private void textBox1_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter) 
            {
                MessageBox.Show ("Hello World");
            }
        }
    }
}
