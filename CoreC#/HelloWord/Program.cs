using System;
using HouseFunction;

namespace HelloWord
{
    class Program
    {

        private static string _first= "Hello";
        private static string _last = "World!";

        static void Main(string[] args)
        {
            Console.WriteLine("Whatever I want");
            Console.WriteLine(_first + _last);

            House objHouse = new House();
            Console.WriteLine(objHouse.getColor());
            objHouse.Price = 8000;
            Console.WriteLine(objHouse.Price);
        }
        
        static string SomeMethod()
        {
            return "Hello World SomeMethod";
        }
    }
}
