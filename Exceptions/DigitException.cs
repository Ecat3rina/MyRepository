using System;
using System.Runtime.Serialization;

namespace Exceptions
{
    [Serializable]
    internal class DigitException : Exception
    {
        public DigitException()
        {
        }

        public DigitException(string message) : base(message)
        {
        }

        public DigitException(string message, Exception innerException) : base(message, innerException)
        {
        }

        protected DigitException(SerializationInfo info, StreamingContext context) : base(info, context)
        {
        }
    }
}