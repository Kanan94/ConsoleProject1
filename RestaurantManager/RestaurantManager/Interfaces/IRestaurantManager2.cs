using RestaurantManager.Enums;
using RestaurantManager.Models;
using System;
using System.Collections.Generic;


namespace RestaurantManager2.Interfaces
{
    interface IRestaurantManager2
    {
        MenuItem MenuItems { get; set; }
        List<Order> Orders { get; set; }
        List<MenuItem> MenuItems { get; set; }
        List<Order> Orders { get; set; }
        MenuItem RestaurantManager2.Interfaces.IRestaurantManager2.MenuItems { get; set; }

        MenuItem AddOrder(Order order, int count);
        MenuItem RemoveOrder(int orderNo);
        MenuItem AddMenuItem(string name, int price, Category category);
        MenuItem RemoveMenuItem(string menuItem);
        MenuItem EditMenuItem(string name, double price, string no);

        List<Order> GetOrdersByDatesInterval(DateTime date1, DateTime date2);
        List<Order> GetOrderByDate(DateTime date);
        List<Order> GetOrdersByPriceInterval(double price1, double price2);
        List<Order> GetOrderByNo(int no);

        List<MenuItem> GetMenuItemsCategory(Category category);
        List<MenuItem> GetMenuItemsPriceInterval(double price1, double price2);
        List<MenuItem> GetMenuItemsSearch();
        void GetMenuItems();
        void GetOrders();
        MenuItem EditMenuItem(string name, double price, string no);
        void AddMenuItem(string name, int price, Category category);
        void AddOrder(Order order, int count);
        MenuItem EditMenuItem(string name, double price, string no);
        MenuItem GetMenuItems();
        List<MenuItem> GetMenuItemsCategory(Category category);
        List<MenuItem> GetMenuItemsPriceInterval(double price1, double price2);
        List<MenuItem> GetMenuItemsSearch(string searchStr);
        List<Order> GetOrderByDate(DateTime date);
        List<Order> GetOrderByNo(int no);
        void GetOrders();
        List<Order> GetOrdersByDatesInterval(DateTime date1, DateTime date2);
        List<Order> GetOrdersByPriceInterval(double price1, double price2);
        void RemoveMenuItem(string menuItemNo);
        void RemoveOrder(int orderNo);
        List<MenuItem> GetMenuItemsSearch();
    }
}
