using System;
using Newtonsoft.Json;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace ReviewSystem_Coursework
{
    class Review
    {
        private string filePath = "Review.txt";
        public string Customer_Name { get; set; }
        public string Contact_Number { get; set; }
        public string Customer_Email { get; set; }
        public string Food_Quality { get; set; }
        public string Staff_Frendliness { get; set; }
        public string Cleanliness { get; set; }
        public string Order_Accuracy { get; set; }
        public string Restaurant_Ambiance { get; set; }
        public string Value_For_Money { get; set; }
        public string Date_Time { get; set; }

        public string Save(Review rv)
        {
            string data = JsonConvert.SerializeObject(rv, Formatting.None);
            Utility.WriteTextFile(filePath, data);
            return "success";
        }
        public List<Review> List()
        {
            string data = Utility.ReadFromFile(filePath);
            if (data != null)
            {
                //Storing the data in the list
                List<Review> list = JsonConvert.DeserializeObject<List<Review>>(data);
                return list;
            }
            return null;
        }

        public List<Review> sortAscending(List<Review> customerList)
        {
            string customerName;
            string customerEmail;
            string customerContact;
            string foodQuality;
            string staffFrendliness;
            string cleanliness;
            string orderAccuracy;
            string restaurantAmbiance;
            string valueForMoney;
            string dateAndTime;

            if (customerList != null)
            {
                for (int i = 0; i < customerList.Count - 1; i++)
                {
                    for (int j = i + 1; j < customerList.Count; j++)
                    {
                        if (customerList[i].Customer_Name.CompareTo(customerList[j].Customer_Name) > 0)
                        {
                            customerName = customerList[i].Customer_Name;
                            customerList[i].Customer_Name = customerList[j].Customer_Name;
                            customerList[j].Customer_Name = customerName;

                            customerEmail = customerList[i].Customer_Email;
                            customerList[i].Customer_Email = customerList[j].Customer_Email;
                            customerList[j].Customer_Email = customerEmail;

                            customerContact = customerList[i].Contact_Number;
                            customerList[i].Contact_Number = customerList[j].Contact_Number;
                            customerList[j].Contact_Number = customerContact;

                            foodQuality = customerList[i].Food_Quality;
                            customerList[i].Food_Quality = customerList[j].Food_Quality;
                            customerList[j].Food_Quality = foodQuality;

                            cleanliness = customerList[i].Cleanliness;
                            customerList[i].Cleanliness = customerList[j].Cleanliness;
                            customerList[j].Cleanliness = cleanliness;

                            staffFrendliness = customerList[i].Staff_Frendliness;
                            customerList[i].Staff_Frendliness = customerList[j].Staff_Frendliness;
                            customerList[j].Staff_Frendliness = staffFrendliness;

                            orderAccuracy = customerList[i].Order_Accuracy;
                            customerList[i].Order_Accuracy = customerList[j].Order_Accuracy;
                            customerList[j].Order_Accuracy = orderAccuracy;

                            restaurantAmbiance = customerList[i].Restaurant_Ambiance;
                            customerList[i].Restaurant_Ambiance = customerList[j].Restaurant_Ambiance;
                            customerList[j].Restaurant_Ambiance = restaurantAmbiance;

                            valueForMoney = customerList[i].Value_For_Money;
                            customerList[i].Value_For_Money = customerList[j].Value_For_Money;
                            customerList[j].Value_For_Money = valueForMoney;

                            dateAndTime = customerList[i].Date_Time;
                            customerList[i].Date_Time = customerList[j].Date_Time;
                            customerList[j].Date_Time = dateAndTime;
                        }
                    }
                }
                return customerList;
            }
            return null;
        }
    }
}