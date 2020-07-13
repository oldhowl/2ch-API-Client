using System;

namespace Wakaba2ChApiClient.Exceptions
{
    public class Wakaba2ChSerializationException : Exception
    {
        public Wakaba2ChSerializationException(string message) : base(message)
        {
        }
    }
}