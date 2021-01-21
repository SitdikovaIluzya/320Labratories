using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace Laboratories320.Sindryakov.TaskRedone
{
    class Tasking
    {
        //4 практика
        //переделываем 3 практику 

        static int[] outcome = new int[10];
        static int[] numbers1 = new int[10];
        static int[] numbers2 = new int[10];

        
        public static void Transform() //генерируем
        {

            Random rnd = new Random();
            for (int i = 0; i < numbers1.Length; i++)
            {
                numbers1[i] = rnd.Next(1, 9);
                Console.WriteLine("Генерирование значений - ");
                Console.Write(numbers1[i] + " ");
                Console.WriteLine();
            }

            for (int i = 0; i < numbers2.Length; i++)
            {
                numbers2[i] = rnd.Next(1, 9);
                Console.WriteLine("Генерирование значений - ");
                Console.Write(numbers2[i] + " ");
                Console.WriteLine();
            }
        }
    }
}


