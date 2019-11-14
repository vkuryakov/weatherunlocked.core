using System;
using System.Collections.Generic;
using System.Net.Http;
using System.Text;

namespace WeatherUnlocked.Core.Exceptions
{
    /// <summary>
    /// Exception for any http status code other than successful and 403 (ForbiddenException is used for 403 http status code)
    /// </summary>
    public class HttpException : Exception
    {
        public HttpResponseMessage Response { get; set; }
        public HttpException(HttpResponseMessage message)
        {
            Response = message;
        }
    }
}
