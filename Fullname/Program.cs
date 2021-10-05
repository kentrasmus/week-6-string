using System;

namespace Fullname
{
    class Program
    {
        static void Main(string[] args)
        {
            //programm kusib kasutajal sisestada eesnime ja perekonnanime
            //programm võrdleb sisestatud andmeid omavahel
            //programm kuvab konsoolis, kumb on pikkem - eesnimi või perekonnanimi

            Console.WriteLine("sisesta oma nimi");
            string username = Console.ReadLine();

            Console.WriteLine("sisesta oma perekonna nimi");
            string usernamelast = Console.ReadLine();

            if (username.Length < usernamelast.Length)
            {
                Console.WriteLine("")
            }
        }
    }
}
