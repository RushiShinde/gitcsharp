using System;
using System.Runtime.Serialization;

namespace FirstApp
{
    [Serializable]
    internal class OddException : Exception
    {
        public OddException()
        {
        }

        public OddException(string message) : base(message)
        {
        }

        public OddException(string message, Exception innerException) : base(message, innerException)
        {
        }

        protected OddException(SerializationInfo info, StreamingContext context) : base(info, context)
        {
        }
    }
}