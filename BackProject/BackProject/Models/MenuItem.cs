using System;
using System.Collections.Generic;
using System.Text;
using BackProject.Enums;
using BackProject.Exceptions;   

namespace BackProject.Models
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
            {
                return _price;
            }
            set
            {
                if (value < 0)
                {
                    throw new MenuModelInvalidExcception("Price", "Qiymet 0-dan az ola bilmez!");
                }

                else
                {
                    _price = value;
                }
            }
        }


        public Category Category { get; set; }
        private static int MenuItemMainCount { get; set; } = 500;
        private static int MenuItemSoupCounT { get; set; } = 500;
        private static int MenuItemDrinkCount { get; set; } = 500;
        private static int MenuItemDessertCount { get; set; } = 500;

        private static string MenuItemMainName { get; set; } = "MA";
        private static string MenuItemSoupName { get; set; } = "SO";
        private static string MenuItemDrinkName { get; set; } = "DR";
        private static string MenuItemMDessertName { get; set; } = "DE";





        public MenuItem(string no, string name, double price, Category category)
        {
            this._no = no;
            this.Name = name;
            this.Price = price;
            this.Category = category;
        }

        public MenuItem(string name, int price, Category category)
        {
            Name = name;
            Price = price;
            Category = category;
        }
    }

}
