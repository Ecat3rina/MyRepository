using System;
using System.Runtime.Serialization;

namespace Exceptions
{
    [Serializable]
    internal class WhiteSpaceException : Exception
    {
        public WhiteSpaceException()
        {
        }

        public WhiteSpaceException(string message) : base(message)
        {
        }

        public WhiteSpaceException(string message, Exception innerException) : base(message, innerException)
        {
        }

        protected WhiteSpaceException(SerializationInfo info, StreamingContext context) : base(info, context)
        {
        }
    }
}