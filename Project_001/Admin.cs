using Microsoft.VisualBasic.Devices;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Numerics;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Linq;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.TrackBar;

namespace Project_001
{
    public partial class Admin : Form
    {
        Products newProducts;
        public Admin()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string pdname = tbName.Text;
            int prc = int.Parse(tbPrice.Text);
            int pdprice = prc;
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
            SaveFileDialog sfd = new SaveFileDialog();
            sfd.Filter = "CSV|*.csv";
            sfd.FileName = "save.csv";
            sfd.ShowDialog();
            StreamWriter sw = new StreamWriter(sfd.FileName);
            if (sfd.FileName != "")
            {
                int rowCount = dataGridView1.RowCount;

                int j = 0;
                for (int i = 0; i < rowCount; i++)
                {
                    sw.WriteLine(dataGridView1.Rows[i].Cells[j].Value.ToString() + "," + dataGridView1.Rows[i].Cells[j + 1].Value.ToString());
                }

                sw.Close();
                MessageBox.Show("Data Saved Successfully !!!", "Info");
            }
        }

        private void Admin_Load(object sender, EventArgs e)
        {

        }
        public List<Products> LoadCSV(string csvFile)
        {
            var qry = from l in File.ReadAllLines(csvFile)
                      let data = l.Split(',')
                      select new Products(
                          pdname: data[0],
                          pdprice: int.Parse(data[1])
                          );
            return qry.ToList();
        }

        private void BindData(string filePath)
        {
            DataTable dt = new DataTable();
            string[] lines = System.IO.File.ReadAllLines(filePath);

            if (lines.Length > 0)
            {
                string firstLine = lines[0];
                string[] headerLabels = firstLine.Split(',');
                foreach (string headerWord in headerLabels)
                {
                    dt.Columns.Add(new DataColumn(headerWord));
                }
                for (int i = 1; i < lines.Length; i++)
                {
                    string[] dataWords = lines[i].Split(',');
                    DataRow dr = dt.NewRow();
                    int columnIndex = 0;
                    foreach (string headerWord in headerLabels)
                    {
                        dr[headerWord] = dataWords[columnIndex++];
                    }
                    dt.Rows.Add(dr);
                }
            }
        }
        private void openToolStripMenuItem_Click(object sender, EventArgs e)
        {
            OpenFileDialog ofd = new OpenFileDialog();
            ofd.ShowDialog();
            textBox1.Text = ofd.FileName;
            if (textBox1.Text == "")
            {

            }
            else
            {
                BindData(ofd.FileName);
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
        }

        private void load_Click(object sender, EventArgs e)
        {
            string filename = textBox1.Text;
            try
            {
                StreamReader sr = new StreamReader(filename);
                string row = "";

                while ((row = sr.ReadLine()) != null)
                {
                    string[] line = row.Split(",");
                    dataGridView1.Rows.Add(line[0], line[1]);
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }
    }
}

