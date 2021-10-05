using System;

namespace FullNameReversed
{
    class Program
    {
        static void Main(string[] args)
        {
            //programm kusib kasutajal sisestada eesnime ja perekonnanime
            //programm kuvab kasutaja eesnime ja perekonnanime tagurpidi
            //*eesnimi ja perekonnanimi kuvatakse eraldi
            //kasutame for-tsüklit

            Console.WriteLine("sisesta oma nimi");
            string username = Console.ReadLine();

            Console.WriteLine("sisesta oma perekonna nimi");
            string usernamelast = Console.ReadLine();

            for (int i = username.Length - 1; i >= 0; i-- )
            {
                Console.Write(username[i]);
            }

            for (int i = usernamelast.Length - 1; i >= 0; i--)
            {
                Console.Write(usernamelast[i]);
            }
        }
    }
}
