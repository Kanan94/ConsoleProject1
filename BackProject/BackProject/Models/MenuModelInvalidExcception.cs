using System;
using System.Runtime.Serialization;

namespace BackProject.Models
{
    [Serializable]
    internal class MenuModelInvalidExcception : Exception
    {
        private string v1;
        private string v2;

        public MenuModelInvalidExcception()
        {
        }

        public MenuModelInvalidExcception(string message) : base(message)
        {
        }

        public MenuModelInvalidExcception(string v1, string v2)
        {
            this.v1 = v1;
            this.v2 = v2;
        }

        public MenuModelInvalidExcception(string message, Exception innerException) : base(message, innerException)
        {
        }

        protected MenuModelInvalidExcception(SerializationInfo info, StreamingContext context) : base(info, context)
        {
        }
    }
}