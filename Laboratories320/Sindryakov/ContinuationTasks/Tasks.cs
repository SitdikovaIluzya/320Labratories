using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace Laboratories320.Sindryakov.ContinuationTasks
{
    class Tasks
    {

        static int[] numbers = new int[20];
        //static int[] outcome = new int[10];
        static int a = 5;
        public static void Task()
        {
            Task task1 = new Task(() => TotalСomposition());
            //Task task1 = new Task(() => ParityCheck());
            task1.Start();


        }

        public static void TotalСomposition() //произведение
        {
            for (int i = 0; i < numbers.Length; i++)
            {
                a *= numbers[i];
                Console.WriteLine("Произведение элементов массива: ");
                Console.Write(numbers[i] + " ");
                Console.WriteLine();
            }
        }

        // деление на 10 через if
        public static void ParityCheck()
        {
            for (int i = 0; i < numbers.Length; i++)
            {
                if (numbers[i] % 10 == 0)
                {

                    //a++;
                }
            }
        }


        public static void Transform() //генерируем
        {

            Random rnd = new Random();
            for (int i = 0; i < numbers.Length; i++)
            {
                numbers[i] = rnd.Next(10, 20);
                Console.WriteLine("Генерирование значений - ");
                Console.Write(numbers[i] + " ");
            }
        }
    }
}
