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
    public partial class graph : UserControl
    {
        public graph()
        {
            InitializeComponent();
            BindChart();
        }

        private void chart2_Click(object sender, EventArgs e)
        {

        }
        public void BindChart()
        {
            Review obj = new Review();
            List<Review> listReview = obj.List();
            DataTable td = Utility.ConvertToTableData(listReview);
            Report_Details rd = new Report_Details();
            rd.dataGrid_report.DataSource = td;
            foodQuality_Chart(listReview);
            Cleanliness_Chart(listReview);
            resturantAmbiance_Chart(listReview);
            valueForMoney_Chart(listReview);
            staffFriendliness_Chart(listReview);
            orderAccuracy_Chart(listReview);

        }
        private void foodQuality_Chart(List<Review> cuslst)
        {
            if (cuslst != null)
            {
                var result = cuslst.GroupBy(l => l.Food_Quality)
                    .Select(cl => new
                    {
                        foodQuality_Chart = cl.First().Food_Quality,
                        Count = cl.Count().ToString(),
                    }).ToList();
                DataTable dt = Utility.ConvertToTableData(result);
                foodQualityChart.DataSource = dt;
                foodQualityChart.Name = "Overall Review";
                foodQualityChart.Series["Food Quality"].XValueMember = "foodQuality_Chart";
                foodQualityChart.Series["Food Quality"].YValueMembers = "Count";
                this.foodQualityChart.Titles.Remove(this.foodQualityChart.Titles.FirstOrDefault());
                this.foodQualityChart.Titles.Add("Food Quality");
            }
        }
        private void Cleanliness_Chart (List<Review> cuslst)
        {
            if (cuslst != null)
            {
                var result = cuslst.GroupBy(l => l.Cleanliness)
                    .Select(cl => new
                    {
                        CleanlinessChart = cl.First().Cleanliness,
                        Count = cl.Count().ToString(),
                    }).ToList();
                DataTable dt = Utility.ConvertToTableData(result);
                cleanlinessChart.DataSource = dt;
                cleanlinessChart.Series["Cleanliness"].XValueMember = "CleanlinessChart";
                cleanlinessChart.Series["Cleanliness"].YValueMembers = "Count";
                this.cleanlinessChart.Titles.Remove(this.cleanlinessChart.Titles.FirstOrDefault());
                this.cleanlinessChart.Titles.Add("Cleanliness");
            }
        }

        private void resturantAmbiance_Chart(List<Review> cuslst)
        {
            if (cuslst != null)
            {
                var result = cuslst.GroupBy(l => l.Restaurant_Ambiance)
                    .Select(cl => new
                    {
                        restaurantAmbianceChart = cl.First().Restaurant_Ambiance,
                        Count = cl.Count().ToString(),
                    }).ToList();
                DataTable dt = Utility.ConvertToTableData(result);
                resturantAmbiance.DataSource = dt;
                resturantAmbiance.Series["Restaurant Ambiance"].XValueMember = "restaurantAmbianceChart";
                resturantAmbiance.Series["Restaurant Ambiance"].YValueMembers = "Count";
                this.resturantAmbiance.Titles.Remove(this.resturantAmbiance.Titles.FirstOrDefault());
                this.resturantAmbiance.Titles.Add("Restaurant Ambiance");
            }
        }

        private void valueForMoney_Chart(List<Review> cuslst)
        {
            if (cuslst != null)
            {
                var result = cuslst.GroupBy(l => l.Value_For_Money)
                    .Select(cl => new
                    {
                        valueForMoneyChart = cl.First().Value_For_Money,
                        Count = cl.Count().ToString(),
                    }).ToList();
                DataTable dt = Utility.ConvertToTableData(result);
                valueForMoney.DataSource = dt;
                valueForMoney.Series["Value of Money"].XValueMember = "valueForMoneyChart";
                valueForMoney.Series["Value of Money"].YValueMembers = "Count";
                this.valueForMoney.Titles.Remove(this.valueForMoney.Titles.FirstOrDefault());
                this.valueForMoney.Titles.Add("Value Of Money");
            }
        }
        private void staffFriendliness_Chart(List<Review> cuslst)
        {
            if (cuslst != null)
            {
                var result = cuslst.GroupBy(l => l.Staff_Frendliness)
                    .Select(cl => new
                    {
                        staffFrendlinessChart = cl.First().Staff_Frendliness,
                        Count = cl.Count().ToString(),
                    }).ToList();
                DataTable dt = Utility.ConvertToTableData(result);
                staffFriendliness.DataSource = dt;
                staffFriendliness.Series["Staff Friendliness"].XValueMember = "staffFrendlinessChart";
                staffFriendliness.Series["Staff Friendliness"].YValueMembers = "Count";
                this.staffFriendliness.Titles.Remove(this.staffFriendliness.Titles.FirstOrDefault());
                this.staffFriendliness.Titles.Add("Staff Friendliness");
            }
        }

        private void orderAccuracy_Chart(List<Review> cuslst)
        {
            if (cuslst != null)
            {
                var result = cuslst.GroupBy(l => l.Order_Accuracy)
                    .Select(cl => new
                    {
                        orderAccuracyChart = cl.First().Order_Accuracy,
                        Count = cl.Count().ToString(),
                    }).ToList();
                DataTable dt = Utility.ConvertToTableData(result);
                orderAccuracy.DataSource = dt;
                orderAccuracy.Series["Order"].XValueMember = "orderAccuracyChart";
                orderAccuracy.Series["Order"].YValueMembers = "Count";
                this.orderAccuracy.Titles.Remove(this.orderAccuracy.Titles.FirstOrDefault());
                this.orderAccuracy.Titles.Add("Order Accuracy");
            }
        }

        private void flowLayoutPanel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void chart2_Click_1(object sender, EventArgs e)
        {

        }

        private void chart1_Click(object sender, EventArgs e)
        {

        }

        private void chart2_Click_2(object sender, EventArgs e)
        {

        }
    }
}
