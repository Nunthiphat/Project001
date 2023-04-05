using Microsoft.VisualBasic.Devices;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Numerics;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Project_001
{
    public partial class Admin : Form
    {
        Products newProducts;
        List<Products> products = new List<Products>();
        public Admin()
        {
            InitializeComponent();

            List<Admin> admins = new List<Admin>();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string pdname = tbName.Text;
            int prc = int.Parse(tbPrice.Text);
            int pdprice = prc;
            Products newProducts = new Products(pdname, pdprice);
            DialogResult = DialogResult.OK;
            if (DialogResult == DialogResult.OK)
            {
                dataGridView1.Rows.Add(pdname, pdprice);
            }
            this.tbName.Text = "";
            this.tbPrice.Text = "";
        }
        public Products getProducts()
        {
            return newProducts;
        }

        private void saveToolStripMenuItem_Click(object sender, EventArgs e)
        {
            SaveFileDialog saveFileDialog = new SaveFileDialog();
            saveFileDialog.Filter = "CSV|*.csv";
            saveFileDialog.ShowDialog();
            if (saveFileDialog.FileName != "")
            {
                using (StreamWriter writer = new StreamWriter(saveFileDialog.FileName))
                {
                    foreach (var item in products)
                    {
                        writer.WriteLine(String.Format(dataGridView1.Rows[0] + "," + dataGridView1.Rows[1]));
                    }
                }
            }
        }

        private void Admin_Load(object sender, EventArgs e)
        {
            
        }

        private void openToolStripMenuItem_Click(object sender, EventArgs e)
        {
            OpenFileDialog openFileDialog1 = new OpenFileDialog();
            openFileDialog1.Filter = "Text files (*.txt)|*.txt|All files (*.*)|*.*";
            openFileDialog1.Title = "Select a file";
            if (openFileDialog1.ShowDialog() == DialogResult.OK)
            {
                StreamReader reader = new StreamReader(openFileDialog1.FileName);
                string row = "";
                string[] lines = File.ReadAllLines(openFileDialog1.FileName);
                while ((row = reader.ReadLine()) != null)
                { 
                    dataGridView1 = new DataGridView();
                    string[] data = row.Split(",");
                    dataGridView1.Rows[0] = data[0];
                    dataGridView1.Rows[1] = data[1] 
                    datagridview1.Rows.Add(data);
                }
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {

        }
    }
}
