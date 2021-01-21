using System;
using System.Collections.Generic;
using System.Text;
using Laboratories320.Kiyamov._5Praktika;
using System.Threading.Tasks;

namespace Laboratories320.Kiyamov._5Praktika
{
    class CountinuationTasks
    {

        static int[] Massive = new int[20];
        public static int result = 1;
        
        public static void Start()
        {
            Task task1 = Task.Run(() => MassiveGenerate());
            Task task2 = task1.ContinueWith(mull => Product());
            Task task3 = task2.ContinueWith(mull => EvenDigits());
            task3.Wait();



        }

        public static void MassiveGenerate()
        {
    {
                Random rnd = new Random();
                for (int i = 0; i < Massive.Length; i++)
                {
                    Massive[i] = rnd.Next(1, 5);

                }
                Console.WriteLine("[{0}]", string.Join(", ", Massive));
            }
        
        }

        public static void Product()
        {

      
            for (int i = 0; i < Massive.GetLength(0); i++)
            {
                result *= Massive[i];
            }
            Console.WriteLine("Произведение = {0}", result);
            Console.ReadKey();
        }
        
        
             public static void EvenDigits()
        {    int c = 1;
            for (int i = 0; i <= result.Length; i++)
            {
                if ((result[i] % 2) == 0)
                {
                    c = result[i];
                    Console.WriteLine("Even digits: " + result);

                }
            }
        }


    }

    }


