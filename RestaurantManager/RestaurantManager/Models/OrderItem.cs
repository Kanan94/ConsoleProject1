using System;
using System.Collections.Generic;
using System.Text;
using RestaurantManager.Models;

namespace RestaurantManager.Models
{
    public class OrderItem
    {
       public MenuItem MenuItem { get; set; }

       public int Count;


       public OrderItem( MenuItem menuItem, int count)
       {
            this.MenuItem = menuItem;
            this.Count = count;
       }
    }
    
}
