using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.IO;
using System.Threading.Tasks;

namespace Ryhmat88
{
    class yl2
    {
        string inFileName = null;

        //TULEB PIDEVALT ERINEVATES ARVUTITES MUUTA :I
        static string f = @"D:\#Games and Apps\GITHUB\Ryhmatoo2--Kristel--Kristiina--Elenn--Katrin-\kttekst.txt";

        static StreamReader sr = new StreamReader(f);
        public static int Alfa()
        {
            //int num_smaller = 0;
            int counter = 0;
            string delim = " ";
            string[] fields = null;

            while (!sr.EndOfStream)
            {
                string line = sr.ReadLine();
                line.Trim();
                fields = line.Split(delim.ToCharArray(), StringSplitOptions.RemoveEmptyEntries);
                counter += fields.Length;
            }
            return counter;
        }

        //public static int Beta()
        //{
        //    int num_smaller = 0;
        //    string delim = " ";
        //    string[] fields = null;

        //    while (!sr.EndOfStream)
        //    {
        //        string line = sr.ReadLine();
        //        line.Trim();
        //        fields = line.Split(delim.ToCharArray(), StringSplitOptions.RemoveEmptyEntries);
        //        foreach (string smaller in fields)
        //        {
        //            if (smaller.Length < 5)
        //            {
        //                num_smaller += 1;
        //            }
        //        }
        //    }
        //    return num_smaller;
        
    }
}