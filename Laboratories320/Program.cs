using Laboratories320.ПРактика2;
using System;
using System.Threading.Tasks;
using System.Threading;
namespace Laboratories320.Gaifullin
 {
    class Program
    {

        static void Main(string[] args)
        {
            Console.WriteLine("Leave hope behind all who enters here....");
            Console.WriteLine();

            int[] array = new int[20];
            Random rnd = new Random();
            for (int i = 0; i < 20; i++)
            {
                array[i] = rnd.Next(1, 10);
            }
            Console.WriteLine("Generating");
            Console.WriteLine("[{0}]", string.Join(", ", array));
            Task task1 = Task.Run(() => PrTask.Сomposition(array));
            Task task2 = task1.ContinueWith(mul => PrTask.Even());
            task2.Wait();


        }
    }
}
