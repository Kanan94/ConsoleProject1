using System;
using System.Collections.Generic;
using System.Text;
using RestaurantManager.Enums;
using RestaurantManager2.Interfaces;
using RestaurantManager.Models;

namespace RestaurantManager.Services
{
    class RestaurantManagerr
    {
        public class RestaurantManager: IRestaurantManager2
        {
            public List<MenuItem> MenuItems { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }
            public List<Order> Orders { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }
            MenuItem IRestaurantManager2.MenuItems { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }

            public RestaurantManager()
            {
                MenuItems = new List<MenuItem>();
                Orders = new List<Order>();
            }

            public void AddMenuItem(string name, int price, Category category)
            {
                string nameStr = name.Trim().ToLower();
                if (MenuItems.Exists(i => i.Name.Trim().ToLower() == nameStr))
                {
                    throw new MenuModelInvalidException("Name", "Menyu itemleri movcuddur!");
                }
            }
           

            public void AddOrder(Order order, int count)
            {
                throw new NotImplementedException();
            }
            public void EditMenuItem(string name, double price, string no)
            {
                throw new NotImplementedException();
            }

            public void GetMenuItems()
            {
                throw new NotImplementedException();
            }

            public List<MenuItem> GetMenuItemsCategory(Category category)
            {
                List<MenuItem> menuItems = MenuItems.FindAll(i => i.Category.Equals(category));
                return menuItems;
            }

            public List<MenuItem> GetMenuItemsPriceInterval(double price1, double price2)
            {
                throw new NotImplementedException();
            }

            public List<MenuItem> GetMenuItemsSearch(string searchStr)
            {
                searchStr = searchStr.Trim().ToLower();
                List<MenuItem> searchedMenuItem = MenuItems.FindAll(b => b.Name.ToLower().Contains(searchStr));
                return searchedMenuItem;
            }

            public List<Order> GetOrderByDate(DateTime date)
            {
                throw new NotImplementedException();
            }

            public List<Order> GetOrderByNo(int no)
            {
                throw new NotImplementedException();
            }

            public void GetOrders()
            {
                throw new NotImplementedException();
            }

            public List<Order> GetOrdersByDatesInterval(DateTime date1, DateTime date2)
            {
                throw new NotImplementedException();
            }

            public List<Order> GetOrdersByPriceInterval(double price1, double price2)
            {
                throw new NotImplementedException();
            }

            public void RemoveMenuItem(string menuItemNo)
            {
                menuItemNo = menuItemNo.Trim().ToLower();
                MenuItem menuRemove = MenuItems.Find(i => i.No.ToLower().Trim().Equals(menuItemNo));
                MenuItems.Remove(menuRemove);

            }

            public void RemoveOrder(int orderNo)
            {
                throw new NotImplementedException();
            }

            public List<MenuItem> GetMenuItemsSearch()
            {
                throw new NotImplementedException();
            }
        }
    }
}
