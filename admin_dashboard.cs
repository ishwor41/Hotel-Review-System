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
    public partial class admin_dashboard : Form
    {
        public admin_dashboard()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {
            addOfCriteria2.Hide();
            report_Details2.Hide();
            graph1.Hide();

        }

        private void button3_Click(object sender, EventArgs e)
        {
            report_Details2.Show();
            report_Details2.BringToFront();
            addOfCriteria2.Hide();

        }

        private void admin_dashboard_Load(object sender, EventArgs e)
        {
            graph1.Hide();
            report_Details2.Hide();
            addOfCriteria2.Hide();
        }

        private void panel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            addOfCriteria2.Show();
            addOfCriteria2.BringToFront();
            report_Details2.Hide();
            graph1.Hide();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            this.Hide();
            Admin_login al = new Admin_login();
            al.Show();
        }

        private void report_Details1_Load(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            graph1.Show();
            graph1.BringToFront();
            addOfCriteria2.Hide();
            report_Details2.Hide();
        }

        private void graph2_Load(object sender, EventArgs e)
        {

        }

        private void graph2_Load_1(object sender, EventArgs e)
        {

        }

        private void graph1_Load(object sender, EventArgs e)
        {
            //graph2.Show();
        }

        private void report_Details2_Load(object sender, EventArgs e)
        {

        }
    }
}
