using System;
using System.Collections.Generic;
using System.Text;

namespace RestaurantManager.Exceptions
{
    public class MenuItemsAlreadyException : Exception
    {

        private string _message;
        public override string Message { get { return _message; } }
        public MenuItemsAlreadyException(string message)
        {
            this._message = message;
        }
    }
}

