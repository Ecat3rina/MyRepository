using System;
using System.Runtime.Serialization;

namespace Exceptions
{
    [Serializable]
    internal class LengthException : Exception
    {
        public LengthException()
        {
        }

        public LengthException(string message) : base(message)
        {
        }

        public LengthException(string message, Exception innerException) : base(message, innerException)
        {
        }

        protected LengthException(SerializationInfo info, StreamingContext context) : base(info, context)
        {
        }
    }
}