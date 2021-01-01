using System;
using System.Collections.Generic;
using System.Text;
using RestaurantManager.Models;
using RestaurantManager.Enums;


namespace RestaurantManager.Interfaces
{
    interface IRestaurantManager
    {
        MenuItem MenuItem { get; set; }
        List<Order> Orders { get; set; }
        void AddOrder(Order order, int count);
        void RemoveOrder(int orderNo);
        void AddMenuItem(string name, int price, Category category );
        void RemoveMenuItem( string menuItem);
        void EditMenuItem( string name, double price, string no);

        List<Order> GetOrdersByDatesInterval(DateTime date1, DateTime date2);
        List<Order> GetOrderByDate(DateTime date);
        List<Order> GetOrdersByPriceInterval(double price1, double price2);
        List<Order> GetOrderByNo(int no);
        //List<MenuItem> GetMenuItemsCategory

    }
}m
