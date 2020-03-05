using System;
using System.Runtime.Serialization;

namespace Exceptions
{
    [Serializable]
    internal class MyFirstException : Exception
    {
        public MyFirstException()
        {
        }

        public MyFirstException(string message) : base(message)
        {
        }

        public MyFirstException(string message, Exception innerException) : base(message, innerException)
        {
        }

        protected MyFirstException(SerializationInfo info, StreamingContext context) : base(info, context)
        {
        }
    }
}