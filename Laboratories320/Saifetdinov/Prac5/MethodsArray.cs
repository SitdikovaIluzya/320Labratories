using System;
using System.Collections.Generic;
using System.Text;

namespace Laboratories320.Saifetdinov.Prac5
{
    static class MethodsArray
    {
        static int[] array = new int[20];
        static int multiplication = 1;
        public static void GenerationElementsArray()
        {
            Random random = new Random();
            for (int i = 0; i < array.Length; i++)
            {
                array[i] = random.Next(-10, 10);
            }
        }
        public static void Multication()
        {
            Console.WriteLine("Multication");
            for (int i = 0; i < array.Length; i++)
            {
                multiplication *= array[i];
            }
            Console.WriteLine(multiplication);
        }
        public static void ParityNumber()
        {
            multiplication
        }
    }
}
