using System;
using System.Runtime.Serialization;

namespace Exceptions
{
    [Serializable]
    internal class FirstLowerException : Exception
    {
        public FirstLowerException()
        {
        }

        public FirstLowerException(string message) : base(message)
        {
        }

        public FirstLowerException(string message, Exception innerException) : base(message, innerException)
        {
        }

        protected FirstLowerException(SerializationInfo info, StreamingContext context) : base(info, context)
        {
        }
    }
}