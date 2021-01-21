using System;
using System.Threading;
using System.Threading.Tasks;
using Laboratories320.threads;


namespace Laboratories320
{
    class Program
    {

        static int[] arr = new int[20];
        static int comp = 1;

        static void Main(string[] args)
        {

            Task task1 = new Task(() => Random_Ar());

            Task task2 = task1.ContinueWith((task1) => Comp());
            Task task3 = task1.ContinueWith((task2) => EvenNum());

            task1.Start();
            task2.Wait();
            task3.Wait();

        }
        static void Random_Ar()
        {

            Random rnd = new Random();
            for (int i = 0; i < arr.Length; i++)
            {
                arr[i] = rnd.Next(1, 5);
            }
            for (int i = 0; i < arr.Length; i++)
            {
                Console.Write(arr[i] + " ");
            }

        }

        static void Comp()
        {
            for (int i = 0; i < arr.Length; i++)
            {
                comp = arr[i] * comp;
            }  
            Console.WriteLine();
            Console.WriteLine("Произведение= " + comp);
        

        }

        static void EvenNum()
        {
            int comp2;
            Console.WriteLine();

            

                comp2 = comp % 10;
                if (comp2 % 2 == 0)
                {
                    Console.Write(comp + " ");
                }
                comp = comp / 10;
            

            
            
        }

    }
}




