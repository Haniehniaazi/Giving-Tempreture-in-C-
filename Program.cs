using System;
using System.Collections.Generic;
using System.Diagnostics.Eventing.Reader;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace ConsoleApp7
{
    internal class Program
    {
        static void Main(string[] args)
        {

            bool continuePlaying = true;

            while (continuePlaying)
            {

                Console.Write("Bitte gib die Temparatur ein: ");
                string temperatur = Console.ReadLine();
                int intTemparautur = int.Parse(temperatur);

                if (intTemparautur <= 0)
                {
                    Thread.Sleep(2000);
                    Console.WriteLine("Gefroren");
                }

                else if (intTemparautur > 0 && intTemparautur < 100)
                {
                    Thread.Sleep(2000);
                    Console.WriteLine("Flüssig");
                }

                else
                {
                    Thread.Sleep(2000);
                    Console.WriteLine("Dampf");
                }

                Thread.Sleep(1000);
                Console.WriteLine("Möchtest du noch mal überprüfen? (ja/nein)");

                string playAgain = Console.ReadLine();

                continuePlaying = (playAgain.ToLower() == "ja");

            }

            Console.WriteLine("Chao dann!");
            Console.ReadKey();
            
            








        }

        
    }
}
