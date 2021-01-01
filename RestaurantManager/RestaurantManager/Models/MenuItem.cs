using System;
using System.Collections.Generic;
using System.Text;
using RestaurantManager.Enums;

namespace RestaurantManager.Models
{
   public class MenuItem
    {
        public string No { get; set; }
        public string Name { get; set; }
        public double Price { get; set; }
        public  Category Category { get; set; }

        public MenuItem (string no, string name, int price, Category category)
        {
            this.No = no;
            this.Name = name;
            this.Price = price;
            this.Category = category;
        }
    }
}
