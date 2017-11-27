using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ryhmat88
{
    class Program
    {
        static void Main(string[] args)
        {

            // 1) Kas listides leidub sarnaseid elemente (ühisosa)
             //var list = new List<string>{ "1", "2", "36", "3", "56", "2" };
            var q = from s in list
                    group s by s into g
                    where g.Count() > 1
                    select g.First();

            foreach (var item in q)
            {
                Console.WriteLine(item);

            }
            //4) Leidge mõlemal listil eraldi numbrite keskmine


            Console.WriteLine("Esimese listi keskmine on: ");
            Console.WriteLine(YlesanneKolm.keskmine1);

            Console.WriteLine("Teise listi keskmine on: ");
            Console.WriteLine(YlesanneKolm.keskmine2);
            


            //Ülesanne 3:
            Console.WriteLine("3. 2)");
            Console.WriteLine("Kahe listi suurim number on:");
            Console.WriteLine(YlesanneKolm.suurim);

            Console.WriteLine("3. 3)");
            Console.WriteLine("Kahe listi väikseim number on:");
            Console.WriteLine(YlesanneKolm.väikseim);

            Console.WriteLine("3. 5)");
            Console.WriteLine("Kahe list numbrite keskmine koos on:");
            Console.WriteLine(YlesanneKolm.Mkeskmine);

        }
    }
}
