using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ReviewSystem_Coursework
{
    public partial class Report_Details : UserControl
    {
        public Report_Details()
        {
            InitializeComponent();
            BindGrid();
        }

        public void BindGrid() { 
            Review rv = new Review();
            List<Review> listReview = rv.List();
            DataTable td = Utility.ConvertToTableData(listReview);
            dataGrid_report.DataSource = td;





        }


        private void dataGrid_report_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void sort_cmd_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (sort_cmd.SelectedItem.ToString().Equals(" Sort by Name"))
            {
                Review rv = new Review();
                List<Review> customerList = rv.List();
               //using sorting method to sort the customername
                List<Review> list = rv.sortAscending(customerList);
                DataTable dt = Utility.ConvertToTableData(list);
                dataGrid_report.DataSource = dt;
            }
        }
    }
}
