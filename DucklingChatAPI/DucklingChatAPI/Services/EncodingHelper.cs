using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Web;

namespace DucklingChatAPI.Services
{
    public static class EncodingHelper
    {
        public static string EncodeTo64(string plainText)
        {
            var plainTextBytes = Encoding.UTF8.GetBytes(plainText);
            return Convert.ToBase64String(plainTextBytes);
        }

        public static string DecodeFrom64(string encodedData)
        {
            var encodedDataAsBytes = Convert.FromBase64String(encodedData);
            var returnValue = Encoding.ASCII.GetString(encodedDataAsBytes);
            return returnValue;
        }
    }
}