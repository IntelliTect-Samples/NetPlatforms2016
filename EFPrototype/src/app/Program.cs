using System;
using EfPrototype.Domain.Models;

namespace EfPrototype.App
{
    public class Program
    {
        public static void Main(string[] args)
        {
            var myEvent = new Event();
            myEvent.Title = "Hello World";
            myEvent.Location = "Spokane Valley";

            Console.WriteLine($"{myEvent.Title} - {myEvent.Location}");

           // Console.WriteLine(dbContext.SayHello("Stokes"));
        }
    }
}
