using RestaurantManager.Enums;
using RestaurantManager.Models;
using System;
using System.Collections.Generic;


namespace RestaurantManager.Interfaces
{
    interface IRestaurantManager
    {
        MenuItem MenuItems { get; set; }
        List<Order> Orders { get; set; }
        void AddOrder(Order order, int count);
        void RemoveOrder(int orderNo);
        void AddMenuItem(string name, int price, Category category);
        void RemoveMenuItem(string menuItem);
        void EditMenuItem(string name, double price, string no);

        List<Order> GetOrdersByDatesInterval(DateTime date1, DateTime date2);
        List<Order> GetOrderByDate(DateTime date);
        List<Order> GetOrdersByPriceInterval(double price1, double price2);
        List<Order> GetOrderByNo(int no);

        List<MenuItem> GetMenuItemsCategory(Category category);
        List<MenuItem> GetMenuItemsPriceInterval(double price1, double price2);
        List<MenuItem> GetMenuItemsSearch();
        void GetMenuItems();
        void GetOrders();

    }
}
