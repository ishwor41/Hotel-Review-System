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
    public partial class Feedback_system : Form
    {
        public Feedback_system()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                Review rv = new Review();
                rv.Customer_Name = custName_txt.Text;
                rv.Contact_Number = contNum_txt.Text;
                rv.Customer_Email = email_txt.Text;
                rv.Food_Quality = foodQuality_cmd.Text;
                rv.Staff_Frendliness = staffFriendliness_cmd.Text;
                rv.Cleanliness = cleanliness_cmd.Text;
                rv.Order_Accuracy = orderAccuracy_cmd.Text;
                rv.Restaurant_Ambiance = resturantAmbiance_cmd.Text;
                rv.Value_For_Money = valueForMoney_cmd.Text;
                rv.Date_Time = DateTime.Now.ToString();

                if (validation() == true)
                {
                    if (custName_txt.Text == "" || contNum_txt.Text == "" || email_txt.Text == "")
                    {
                        rv.Customer_Name = "Unknown";
                        rv.Customer_Email = "Unknown";
                        rv.Contact_Number = "Unknown";
                    }
                    string flag = rv.Save(rv);
                    //Resetting value after submitting the data
                    if (flag == "success")
                    {
                        resetForm();
                        MessageBox.Show("Thank You For your Feed back !", "Feed Back");
                    }
                }
                //Resetting value after submitting the data

            }
            catch (Exception ex)
            {
                MessageBox.Show(" Please fill all the value in the field ! ");
            }


        }

        private bool validation()
        {
            if (foodQuality_cmd.SelectedItem == null || staffFriendliness_cmd.SelectedItem == null || cleanliness_cmd.SelectedItem == null || orderAccuracy_cmd.SelectedItem == null || resturantAmbiance_cmd.SelectedItem == null || valueForMoney_cmd.SelectedItem == null)
            {
                MessageBox.Show("Pleas enter the values in the field !!!!", "error");
                return false;
            }
            else
            {
                return true;
            }
        }

        public void resetForm()
        {
            custName_txt.Text = "";
            contNum_txt.Text = "";
            email_txt.Text = "";
            foodQuality_cmd.Text = "";
            staffFriendliness_cmd.Text = "";
            cleanliness_cmd.Text = "";
            orderAccuracy_cmd.Text = "";
            resturantAmbiance_cmd.Text = "";
            valueForMoney_cmd.Text = "";
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void resturantAmbiance_cmd_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void staffFriendliness_cmd_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void orderAccuracy_cmd_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void cleanliness_cmd_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void label9_Click(object sender, EventArgs e)
        {

        }

        private void label8_Click(object sender, EventArgs e)
        {

        }

        private void label7_Click(object sender, EventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void email_txt_TextChanged(object sender, EventArgs e)
        {

        }

        private void contNum_txt_TextChanged(object sender, EventArgs e)
        {

        }

        private void custName_txt_TextChanged(object sender, EventArgs e)
        {

        }

        private void valueForMoney_cmd_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
