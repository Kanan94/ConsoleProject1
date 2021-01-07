using System;
using System.Collections.Generic;
using System.Text;
using BackProject.Models;
using BackProject.Enums;

namespace BackProject.Interfaces
{
    interface IRestaurantManager
    {
        List<Order> Orders { get; set; }
        List<MenuItem> MenuItems { get; set; }

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
        List<MenuItem> GetMenuItemsSearch(string searchStr);
    }
}
