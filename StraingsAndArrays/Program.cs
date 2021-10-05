using System;

namespace StraingsAndArrays
{
    class Program
    {
        static void Main(string[] args)
        {
            //programm kusib kasutajalt sisestada eesnime
            //programm kusib kasutaja eesnime pikkust

            Console.WriteLine("Hello, what is your name?");
            string username = Console.ReadLine();
            Console.WriteLine($"Hello, {username}");
            
            Console.WriteLine($"Sinu {username.Length} sümbolit pikk");



        }
    }
}
