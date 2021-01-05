using System;
using System.Runtime.Serialization;

namespace RestaurantManager.Models
{
    [Serializable]
    internal class MenuModelInvalidException : Exception
    {
        private string v1;
        private string v2;

        public MenuModelInvalidException()
        {
        }

        public MenuModelInvalidException(string message) : base(message)
        {
        }

        public MenuModelInvalidException(string v1, string v2)
        {
            this.v1 = v1;
            this.v2 = v2;
        }

        public MenuModelInvalidException(string message, Exception innerException) : base(message, innerException)
        {
        }

        protected MenuModelInvalidException(SerializationInfo info, StreamingContext context) : base(info, context)
        {
        }
    }
}