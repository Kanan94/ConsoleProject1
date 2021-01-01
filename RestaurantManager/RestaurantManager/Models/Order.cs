using System;
using System.Collections.Generic;
using System.Text;

namespace RestaurantManager.Models
{
    public class Order
    {
        public string No { get; set; }
        List<OrderItems> OrderItems { get; set; }
        public double TotalAmount { get; set; }
        //public DateTime

        public Order(string no, string orderItems, double totalAmount)
        {
            this.No = no;
            //this.OrderItems = orderItems;
            this.TotalAmount = totalAmount;
            //this.Date = date;


        }


    }
}
