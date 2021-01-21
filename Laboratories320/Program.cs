using System;
using Laboratories320.Zakirov._2Thread;
using Laboratories320.Zakirov._3ThreadLocker;
using Laboratories320.Zakirov._4ThreadTask;
using System.Threading.Tasks;

namespace Laboratories320
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] numbers = new int[20];
            int result = 1;

            Random rnd = new Random();
            for (int i = 0; i < numbers.Length; i++)
            {
                numbers[i] = rnd.Next(1, 5);
                Console.Write(numbers[i] + " ");
            }
            Console.WriteLine();
            
            for (int i = 0; i < numbers.Length; i++)
            {
                result *= numbers[i];
            }
            Console.Write(result);
        }
    }
}
