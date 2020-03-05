using System;
using System.Runtime.Serialization;

namespace Exceptions
{
    [Serializable]
    internal class MySecondException : Exception
    {
        public MySecondException()
        {
        }

        public MySecondException(string message) : base(message)
        {
        }

        public MySecondException(string message, Exception innerException) : base(message, innerException)
        {
        }

        protected MySecondException(SerializationInfo info, StreamingContext context) : base(info, context)
        {
        }
    }
}