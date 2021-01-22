using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace Laboratories320.Sindryakov.ContinuationTasks
{
    class Tasks
    {
        // практика 5, переделка
        static int[] numbers = new int[20];
        //static int[] outcome = new int[10];
        static int numeric = 1;
        public static void Task()
        {
            Task task1 = new Task(TotalСomposition);
            Task task2 = new Task(ParityCheck);
            Task task3 = task2.ContinueWith(check => ParityCheck());
            task1.Start();
            task2.Start();
            task3.Wait();

        }

        public static void TotalСomposition() //произведение
        {
            for (int i = 0; i < numbers.Length; i++)
            {
                numeric *= numbers[i];
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
                if (numbers[i] % 2 == 0 && numbers[i] != 0)
                {
                    Console.WriteLine(numbers[i]);
                }
            }
        }


        public static void Transform() //генерируем
        {
            Random rnd = new Random();
            for (int i = 0; i < numbers.Length; i++)
            {
                numbers[i] = rnd.Next(-10, 100);
                Console.WriteLine("Генерирование значений - ");
                Console.Write(numbers[i] + " ");
            }
        }
    }
}
