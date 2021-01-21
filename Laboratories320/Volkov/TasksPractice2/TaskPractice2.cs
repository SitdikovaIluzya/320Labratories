using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace Laboratories320.Volkov.TasksPractice2
{
    public class TaskPractice2
    {
        static int[] arr = new int[20];
        static int product = 1;
        static string digit = "";
        static int evendigit;

        static void FillArr()
        {
            Random rnd = new Random();
            Console.Write("Исходный массив:  ");
            for (int i = 0; i < arr.Length; i++)
            {
                arr[i] = rnd.Next(1, 5);
                Console.Write(arr[i] + ", ");
            }
            Console.WriteLine();
        }
        static void ProductArr()
        {
            Console.Write("Найденное произведение: ");
            
            for (int i = 0; i < arr.Length; i++)
            {
                product = product * arr[i];
            }
            Console.WriteLine(product);
        }

        static void FindEvenNumbers()
        {
            digit = product.ToString();
            Console.Write("Четные числа: ");
            for (int i = 0; i < digit.Length; i++)
            {
                if (product % 2 == 0)
                {
                    evendigit = product % 2;
                    product = product / 10;
                }
                else product = product / 10;
            }
            Console.WriteLine(evendigit);
        }

        public static void Work()
        {
            Task fill = new Task(FillArr);
            fill.Start();
            fill.Wait();
            Task productarr = new Task(ProductArr);
            productarr.Start();
            productarr.Wait();
            Task findevendig = new Task(FindEvenNumbers);
            findevendig.Start();
            findevendig.Wait();
            
        }
    }
}
