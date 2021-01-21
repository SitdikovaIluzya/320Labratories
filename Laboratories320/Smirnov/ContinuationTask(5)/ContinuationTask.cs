using System;
using System.Collections.Generic;
using System.Text;

namespace Laboratories320.Smirnov.ContinuationTask_5_
{
    class ContinuationTask
    {
        //найти произведение всех элементов,
        //и получите только четные цифры из результата.
        //Создайте правильную последовательность задач продолжения.
        int[] arr = new int[20];
        int product = 1;

        void Generate()
        {
            Random random = new Random();
            for (int i = 0; i < arr.Length; i++)
            {
                arr[i] = random.Next(-50, 50);
            }
        }
        void Product()
        {
            for (int i = 0; i < arr.Length; i++)
            {
                product *= arr[i];
            }
        }
        void Even()
        {
            string emp = "";
            while (product != 0)
            {
                if ((product % 10) % 2 == 0)
                {
                    emp += product;
                }
                product = product / 10;
            }
            Console.WriteLine("Количество четных цыфр: {0}", product);
            Console.ReadKey();
        } 
    }
}
