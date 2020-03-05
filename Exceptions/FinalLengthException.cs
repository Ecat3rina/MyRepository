using System;
using System.Runtime.Serialization;

namespace Exceptions
{
    [Serializable]
    internal class FinalLengthException : Exception
    {
        public FinalLengthException()
        {
        }

        public FinalLengthException(string message) : base(message)
        {
        }

        public FinalLengthException(string message, Exception innerException) : base(message, innerException)
        {
        }

        protected FinalLengthException(SerializationInfo info, StreamingContext context) : base(info, context)
        {
        }
    }
}