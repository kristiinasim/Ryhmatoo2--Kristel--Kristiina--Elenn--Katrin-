﻿using System;
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


            //------------------------Ülesanne-3-------------------------

            //3. Ülesanne 1) punkt:
            Console.WriteLine("");
            Console.WriteLine("=======");
            Console.WriteLine("3. 1)");
            Console.WriteLine("=======");
            Console.WriteLine("Kahe listi ühisosad on:");
            foreach (int element in YlesanneKolm.Array1)
            {
                foreach (int eliment in YlesanneKolm.Array2)
                {
                    if (eliment == element)
                    {
                        Console.WriteLine("---> " + eliment + " <---");
                    }
                }

            }

            //3. Ülesanne 2) punkt:
            Console.WriteLine("");
            Console.WriteLine("=======");
            Console.WriteLine("3. 2)");
            Console.WriteLine("=======");
            Console.WriteLine("Kahe listi suurim number on:");
            Console.WriteLine("---> " + YlesanneKolm.suurim + " <---");

            //3. Ülesanne 3) punkt:
            Console.WriteLine("");
            Console.WriteLine("=======");
            Console.WriteLine("3. 3)");
            Console.WriteLine("=======");
            Console.WriteLine("Kahe listi väikseim number on:");
            Console.WriteLine("---> " + YlesanneKolm.väikseim + " <---");

            //3. Ülesanne 4) punkt:
            Console.WriteLine("");
            Console.WriteLine("=======");
            Console.WriteLine("3. 4)");
            Console.WriteLine("=======");
            Console.WriteLine("Esimese listi keskmine on: ");
            Console.WriteLine("---> " + YlesanneKolm.keskmine1 + " <---");
            Console.WriteLine("Teise listi keskmine on: ");
            Console.WriteLine("---> " + YlesanneKolm.keskmine2 + " <---");

            //3. Ülesanne 5) punkt:
            Console.WriteLine("");
            Console.WriteLine("=======");
            Console.WriteLine("3. 5)");
            Console.WriteLine("=======");
            Console.WriteLine("Kahe listi numbrite keskmine koos on:");
            Console.WriteLine("---> " + YlesanneKolm.Mkeskmine + " <---");

        }
    }
}
