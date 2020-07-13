using System;
using System.Net;

namespace Wakaba2ChApiClient.Exceptions
{
    public class Wakaba2ChHttpException : Exception
    {
        public Wakaba2ChHttpException(HttpStatusCode httpStatusCode, string message) : base($"HTTP ошибка {httpStatusCode}: {message}")
        {
        }
        
        public Wakaba2ChHttpException(string message) : base($"Ошибка сериализации json: {message}")
        {
        }
    }
}