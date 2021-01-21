using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace Laboratories320.Saifetdinov.Prac5
{
    public static class ArrayMethods
    {
        static int[] array = new int[20];
        static int multiplication = 1;
        public static void GenerationElementsArray()
        {
            Console.Write("Array - ");
            Random random = new Random();
            for (int i = 0; i < array.Length; i++)
            {
                array[i] = random.Next(1, 4);
                Console.Write(array[i]);
            }
            Console.WriteLine();
        }
        public static void Multication()
        {
            for (int i = 0; i < array.Length; i++)
            {
                multiplication *= array[i];
            }
            Console.WriteLine($"Multiplication - {multiplication}");
        }
        public static void ParityNumber()
        {
            Console.Write("Parity Number - ");
            int number;
            while (multiplication > 10)
            {
                number = multiplication % 10;
                if (number % 2 == 0)
                {
                    Console.Write($"{number} ");
                }
                multiplication /= 10;
            }
            if (multiplication % 2 == 0)
            {
                Console.Write(multiplication);
            }
        }
    }
}
