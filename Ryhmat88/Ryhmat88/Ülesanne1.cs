using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ryhmat88
{
    class ülesanne1 : Program
    {
        public static int Ajunuss(int arv1, int arv2)
        {
            if (arv1 < arv2)
            {
                while (arv1 < arv2 - 1)
                {
                    arv1++;
                    if (arv1 % 2 == 0)
                    {
                        Console.WriteLine(arv1);
                    }

                }
            }
            else
            {
                while (arv2 < arv1 - 1)
                {
                    arv2++;
                    if (arv2 % 2 == 0)
                    {
                        Console.WriteLine(arv2);
                    }
                }

            }
            return 0;
        }
    }
}
