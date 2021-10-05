using System;

namespace CharacterCounter
{
    class Program
    {
        static void Main(string[] args)
        {
            //programm kusib kasutajal sisestada eesnimi ja perekonnanime
            //programm kuvab, mitu "a" tahte kasutaja eesnimes ja perekonnanimes kokku on

            Console.WriteLine("sisesta oma nimi");
            string username = Console.ReadLine();

            Console.WriteLine("sisesta oma perekonna nimi");
            string usernamelast = Console.ReadLine();

            string fullname = $"{username}{usernamelast}";

            /* int counter = 0;


             foreach (char  character in fullname)
             {
                 if(character == 'a')
                 {
                     counter++;
                 }
             }
             */
            /* int counter = 0;

             int i = fullname.Length - 1;
             while (i >= 0)
             {
                 Console.WriteLine(fullname[i]);
                 if(fullname[i] == 'a')
                 {
                     counter++;
                 }
                 i--;
                 */
            int counter = 0;
            for(int i = 0; i < fullname.Length; i++)
            {
                if(fullname[i] == 'a')
                {
                    counter++;
                }
                    
            }


            Console.WriteLine($"sinu nimes on {counter} a tahte.");
        }

        

           
            
    }
 
}
