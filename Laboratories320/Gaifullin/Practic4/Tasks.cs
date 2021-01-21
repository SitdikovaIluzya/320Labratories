using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
using System.Threading;
namespace Laboratories320
{
    class Tasks
    {
        public static int[] array1 = new int[5];
        public static int[] array2 = new int[5];
        public static int[] array3 = new int[5];

        static object Sum = new object();
        static object Result = new object();

        public static void ThTasks()
        {
            Task task1 = new Task(() => Generator());
            Task task2 = Task.Run(() => Summ());
            task1.Start();           
            task2.Wait();
            Console.WriteLine("[{0}]", string.Join(", ", array1));
            Console.WriteLine("[{0}]", string.Join(", ", array2));
            Console.WriteLine("[{0}]", string.Join(", ", array3));
        }
        public static void Generator()
        {          
                Random rnd = new Random();
                for (int i = 0; i < 5; i++)
                {
                    array1[i] = rnd.Next(-5, 5);
                    array2[i] = rnd.Next(-5, 5);
                }
                Console.WriteLine("Generating");
            
        }
        public static void Summ()
        {        
            
                for (int i = 0; i < 5; i++)
                {
                    array3[i] = array1[i] + array2[i];
                }
                Console.WriteLine("Summ");           
        }
    }
}
