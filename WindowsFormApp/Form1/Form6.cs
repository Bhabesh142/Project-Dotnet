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
    public partial class Form6 : Form
    {
        public Form6()
        {
            InitializeComponent();
        }

        private void Form6_Load(object sender, EventArgs e)
        {
            listView1.View = View.Details;
            listView1.GridLines = true;
            listView1.FullRowSelect = true;

            //Add column header
            listView1.Columns.Add("ProductName", 100);
            listView1.Columns.Add("Price", 70);
            listView1.Columns.Add("Quantity", 70);

            //add item in the listview
            string[] arr = new string[4];
            ListViewItem itm;

            //Add first item
            arr[0] = "TV";
            arr[1] = "121000";
            arr[2] = "10";
            itm = new ListViewItem(arr);
            listView1.Items.Add(itm);

            //Add second item
            arr[0] = "Refrigerator";
            arr[1] = "70000";
            arr[2] = "5";
            itm = new ListViewItem(arr);
            listView1.Items.Add(itm);

            //Add third item
            arr[0] = "Microwave";
            arr[1] = "4500";
            arr[2] = "4";
            itm = new ListViewItem(arr);
            listView1.Items.Add(itm);

            //Add fourth item
            arr[0] = "Usha Fans";
            arr[1] = "1000";
            arr[2] = "6";
            itm = new ListViewItem(arr);
            listView1.Items.Add(itm);

            //Add fifth item
            arr[0] = "AC";
            arr[1] = "25000";
            arr[2] = "3";
            itm = new ListViewItem(arr);
            listView1.Items.Add(itm);

        }

        private void button1_Click(object sender, EventArgs e)
        {
            string ProductName = null;
            string Price = null;
            string Quantity = null;
             
            ProductName = listView1.SelectedItems[0].SubItems[0].Text;
            Price = listView1.SelectedItems[0].SubItems[1].Text;
            Quantity = listView1.SelectedItems[0].SubItems[2].Text;

            MessageBox.Show(ProductName + " , " + Price + " ," + Quantity);

        }
    }
}
