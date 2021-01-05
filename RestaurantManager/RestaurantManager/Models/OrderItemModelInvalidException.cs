using System;
using System.Runtime.Serialization;

namespace RestaurantManager.Models
{
    [Serializable]
    internal class OrderItemModelInvalidException : Exception
    {
        private string v1;
        private string v2;

        public OrderItemModelInvalidException()
        {
        }

        public OrderItemModelInvalidException(string message) : base(message)
        {
        }

        public OrderItemModelInvalidException(string v1, string v2)
        {
            this.v1 = v1;
            this.v2 = v2;
        }

        public OrderItemModelInvalidException(string message, Exception innerException) : base(message, innerException)
        {
        }

        protected OrderItemModelInvalidException(SerializationInfo info, StreamingContext context) : base(info, context)
        {
        }
    }
}