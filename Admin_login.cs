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
    public partial class Admin_login : Form
    {
        public Admin_login()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            string userName = username_txt.Text;
            string password = password_txt.Text;

            if (userName == "admin" && password == "admin")
            {
                this.Hide();
                admin_dashboard ad = new admin_dashboard();
                ad.Show();
            }
            else
            {
                MessageBox.Show("The username or passwor you entered is incorrect.");
            }
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            Feedback_system fs = new Feedback_system();
            fs.Show();
            this.Hide();
        }

        private void username_txt_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
