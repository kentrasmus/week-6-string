﻿using System;

namespace ForEach
{
    class Program
    {
        static void Main(string[] args)
        {
            //programm kuvab sone pikkust lenght omaduse kasutamata 

            // foreach loop
            //foreach(element in string)

            string helloworld = "Hello World";

            int counter = 0;

            foreach(char character in helloworld)
            {
                counter = counter + 1;
                    //counter++;
            }
            Console.WriteLine($"{helloworld} on {counter} sumbolit pikk.");
           
        }
    }
}
