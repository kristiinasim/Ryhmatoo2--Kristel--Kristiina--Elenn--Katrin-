using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ryhmat88
{
    class YlesanneKolm
    {
        //Antud listid:
        public static int[] Array1 = { 11, 15, 6, 13, 13, 25, 32, 11, 20, 5, 31, 16, 32, 29, 11, 13, 3, 29, 28, 24 };
        public static int[] Array2 = { 5, 19, 16, 4, 12, 7, 2, 28, 34, 29, 29, 36, 6, 8, 24, 18, 31, 7, 1, 7 };

        //Liidan listid kokku:
        public static int[] KaksArrayd = Array1.Concat(Array2).ToArray();

        //Arvutan maksimumi, miinimumi ja keskmise kahe listi peale kokku:
        public static int suurim = KaksArrayd.Max();
        public static int väikseim = KaksArrayd.Min();
        public static double Mkeskmine = KaksArrayd.Average();
    }
}
