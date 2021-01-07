using System;
using System.Collections.Generic;
using System.Text;

namespace BackProject.Models
{
    public class Order
    {
        private string _no;
        private double _totalAmount;
        private string _orderItems;
        private int _dateTime;


        public string No { get { return _no; } }
        List<OrderItem> OrderItems { get; set; }
        public double TotalAmount { get { return _totalAmount; } }
        public DateTime Date { get; set; }

        public Order(string no, string orderItems, double totalAmount, int datetime)
        {
            this._no = no;
            this._orderItems = orderItems;
            this._totalAmount = totalAmount;
            this._dateTime = datetime;


        }

        
    }

}
