using System;
using System.Collections.Generic;
using System.Text;

namespace WeatherUnlocked.Core.Exceptions
{
    /// <summary>
    /// Exception for 403 http status code. WeatherUnlocked API returns 403 http status code when there is a problem
    /// with a key, a subscription or an account.
    /// </summary>
    public class ForbiddenException : Exception
    {
        public ForbiddenException(string message) : base(message){}
    }
}
