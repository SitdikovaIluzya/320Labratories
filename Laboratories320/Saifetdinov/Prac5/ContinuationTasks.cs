using System;
using System.Collections.Generic;
using System.Text;

namespace Laboratories320.Saifetdinov.Prac5
{
    static class ContinuationTasks
    {

        static int[] array = new int[20];
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
            for (int i = 0; i < array.Length; i++)
            {
                array[i] *= array[i];
            }
        }
    }
}
