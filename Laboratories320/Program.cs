using System;
using System.Threading;
using System.Threading.Tasks;
using Laboratories320.threads;


namespace Laboratories320
{
    class Program
    {

        static int[] arr1 = new int[10];
        static int[] arr2 = new int[10];
        static int[] arr3 = new int[10];
        
        static void Main(string[] args)
        {

            Task task1 =  Task.Run(()=>Random_Ar());
            task1.Wait();
            Task task2 = new Task(()=>Sum());
            task2.Start();
        }
        static void Random_Ar()
        {
            
                Random rnd = new Random();
                for (int i = 0; i < 10; i++)
                {
                    arr1[i] = rnd.Next(10);
                    arr2[i] = rnd.Next(10);
                }
                for (int i = 0; i < 10; i++)
                {
                    Console.WriteLine(arr1[i] + "," + arr2[i]);
                }
            
        }

        static void Sum()
        {
            for (int i = 0; i < 10; i++)
            {
                arr3[i] = arr1[i] + arr2[i];
            }
            for (int i = 0; i < 10; i++)
            {
                Console.WriteLine("Сумма: "+arr3[i]);
            }
        }
    }

}

    


