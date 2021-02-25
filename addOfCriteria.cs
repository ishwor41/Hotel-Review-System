using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace ReviewSystem_Coursework
{
    public partial class addOfCriteria : UserControl
    {
        public addOfCriteria()
        {
            InitializeComponent();
        }

        private void addOfCriteria_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (addCriteria_txt.Text == "")
            {
                MessageBox.Show("Cannot add empty item in criteria", "Error");
            }
            else
            {
                WriteToTextFile(_path);
            }
        }

        private string _path = "Criteria.txt";
        private void WriteToTextFile(string _path, bool append = true)
        {
            StreamWriter sw = new StreamWriter(_path, append);
            sw.WriteLine(addCriteria_txt.Text);
            MessageBox.Show("New Criteria Added", "Info");
            sw.Close();
        }


        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void import_btn_Click(object sender, EventArgs e)
        {
            Import_Criteria();

        }
        private void Import_Criteria()
        {

            DataTable dt = new DataTable();

            List<string[]> list = new List<string[]>();
            int maxItem = 0;
            using (TextReader tr = File.OpenText((@"Criteria.txt")))
            {
                string line;
                while ((line = tr.ReadLine()) != null)
                {

                    string[] items = line.Trim().Split(',');

                    if (maxItem <= items.Count())
                    {
                        maxItem = items.Count();
                    }

                    list.Add(items);
                }

                dt.Columns.Add(new DataColumn("Criteria", typeof(string)));
                dt.Columns.Add(new DataColumn("Excellent", typeof(string)));
                dt.Columns.Add(new DataColumn("Good", typeof(string)));
                dt.Columns.Add(new DataColumn("Average", typeof(string)));
                dt.Columns.Add(new DataColumn("Dissatisfied", typeof(string)));

                foreach (var items in list)
                {
                    dt.Rows.Add(items);
                }

                //show it in gridview 
                this.criteria_grid.DataSource = dt;
            }
        }
    
    }
}
