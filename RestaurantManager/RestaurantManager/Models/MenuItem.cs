using System;
using System.Collections.Generic;
using System.Text;
using RestaurantManager.Enums;

namespace RestaurantManager.Models
{
   public class MenuItem
    {
        private string _no;
        private string _name;
        private double _price;
        

        public string No { get { return _no; } }
        public string Name { get; set; }
        public double Price
        {
            get
            { return _price;
            }
            set
            {
                if (value < 0)
                {
                    throw new MenuModelInvalidException("Price", "Price can not be less than zero!");
                }

                else
                {
                    _price = value;
                }
                }
            }
        }

        public  Category Category { get; set; }




    //public MenuItem(string no, string name, int price, Category category)
    //{
    //    //this.No = no;
    //    //this.Name = name;
    //    //this.Price = price;
    //    this.Category = category;
    //}
}


