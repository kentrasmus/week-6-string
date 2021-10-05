using System;

namespace Substring
{
    class Program
    {
        static void Main(string[] args)
        {
            string helloworld = "Hello World!";
            string partToLookFor = "hello";


            bool isThere;

          isThere =  helloworld.ToLower().Contains(partToLookFor);

            if (isThere)
            {
                Console.WriteLine($"leidsin {partToLookFor} ules!");
            }
            else
            {
                Console.WriteLine($"EI LEIDNUD {partToLookFor}");
            }

        }
    }
}
