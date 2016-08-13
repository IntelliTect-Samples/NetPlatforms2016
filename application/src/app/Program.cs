using System;
using ClassLibrary;

namespace ConsoleApplication
{
    public class Program
    {
        public static void Main(string[] args)
        {
            var sayHello = new SayHello();
            Console.WriteLine($"{sayHello.SayHi("Stokes")}!");
        }
    }
}
