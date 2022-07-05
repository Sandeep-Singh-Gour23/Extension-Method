using System;
using Extension_Method;

namespace Extension_Method
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter the value..............");
            string input = Console.ReadLine();
            string currency = ExtensionMethod.ToCurrency(input);
            Console.WriteLine(currency);
        }
    }
}
