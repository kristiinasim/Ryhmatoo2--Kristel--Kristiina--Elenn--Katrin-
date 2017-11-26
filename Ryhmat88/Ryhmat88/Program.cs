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
           
             //var list = new List<string> { "1", "2", "36", "3", "56", "2" };  
             //var list2 = new List<string> { "11", "2", "36", "73", "56", "2" };

            double result = (from x in list select x.Length).Average();
            Console.WriteLine(result);

            double result2 = (from x in list2 select x.Length).Average();
            Console.WriteLine(result2);
            Console.ReadLine();
        }
    }
}
