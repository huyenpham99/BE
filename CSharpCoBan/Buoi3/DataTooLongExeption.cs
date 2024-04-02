using System;
using System.Runtime.Serialization;

namespace Buoi3.Buoi3
{
    [Serializable]
    internal class DataTooLongExeption : Exception
    {
        public DataTooLongExeption()
        {
        }

        public DataTooLongExeption(string message) : base(message)
        {
        }

        public DataTooLongExeption(string message, Exception innerException) : base(message, innerException)
        {
        }

        protected DataTooLongExeption(SerializationInfo info, StreamingContext context) : base(info, context)
        {
        }
    }
}