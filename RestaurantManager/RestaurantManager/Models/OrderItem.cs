using System;
using System.Collections.Generic;
using System.Text;
using RestaurantManager.Models;

namespace RestaurantManager.Models
{
    public class OrderItem
    {
        private int _count;
        public MenuItem MenuItem { get; set; }

        public int Count
        {
            get
            {
                { return _count; }
            }
            set
            {
                if (value < 0)
                {
                    throw new OrderItemModelInvalidException("Count", "Say 0-dan az ola bilmez !");
                }

                else
                {
                    this._count = value;
                }

            }
        }


        public OrderItem(MenuItem menuItem, int count)
        {
            this.MenuItem = menuItem;
            this.Count = count;
        }
    }

}
