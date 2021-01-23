using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
using System.Threading;

namespace Laboratories320.Gaifullin
{
    //Продолжение 4 практики
    class PrTask
    {
        public static int Composit = 1;
        public static void Сomposition(int[] array)
        {
            for (int i = 0; i < 20; i++)
            {
                Composit = Composit * array[i];
            }
            Console.WriteLine("Итог умножения: " + Composit);

        }

        public static void Even()
        {
            string comp = Composit.ToString();
            string EvenDigits = "";
            for (int i = 0; i < comp.Length; i++)
            {
                if (comp[i] % 2 == 0)
                {
                    EvenDigits += comp[i];
                }
            }
            Console.WriteLine("Четные числа: " + EvenDigits);

        }
    }
}
