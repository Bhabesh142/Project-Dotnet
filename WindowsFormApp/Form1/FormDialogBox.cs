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
    public partial class FormDialogBox : Form
    {
        public FormDialogBox()
        {
            InitializeComponent();
        }

        private void FormDialogBox_Load(object sender, EventArgs e)
        {
            
        }

        private void button1_Click(object sender, EventArgs e)
        {
            FontDialog fd = new FontDialog();
            fd.ShowDialog();

            if (fd.ShowDialog() == DialogResult.OK)
            {
                string fontname;
                float fontsize;
                fontname = fd.Font.Name;


                fontsize = fd.Font.Size;
                MessageBox.Show(fontname +" " + fontsize + " ");
            }

        }
    }
}
