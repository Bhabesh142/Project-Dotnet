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
    public partial class FormColorDialogueBox : Form
    {
        public FormColorDialogueBox()
        {
            InitializeComponent();
        }

        private void FormColorDialogueBox_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            ColorDialog cd = new ColorDialog();
            cd.ShowDialog();
            if (cd.ShowDialog()==DialogResult.OK)
            {
                string str = null;
                str = cd.Color.Name;
                MessageBox.Show(str);
            }
        }
    }
}
