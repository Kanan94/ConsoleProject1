using System;
using System.Collections.Generic;
using System.Text;
using BackProject.Models;

namespace BackProject.Models
{
    public class OrderItems
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


        public OrderItems(MenuItem menuItem, int count)
        {
            this.MenuItem = menuItem;
            this.Count = count;
        }
    }

}
