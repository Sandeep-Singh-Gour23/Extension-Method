using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace Extension_Method
{
    public class InvalidInputException : Exception
    {
        public InvalidInputException(String message)
            : base(message)
        {

        }
    }
    public static class ExtensionMethod
    {
        public static string ToCurrency(this string str)
        {
            //var isNumeric = int.TryParse(str, out _);
            var isNumeric = Regex.IsMatch(str, @"^\d+$");

            if (isNumeric)
                return "$" + str;

            else
                throw new InvalidInputException("Sorry, you have entered invalid value.");
        }
    }
}
