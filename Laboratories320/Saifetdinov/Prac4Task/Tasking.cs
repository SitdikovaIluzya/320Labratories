using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace Laboratories320.Saifetdinov.Prac4Task
{
    class Tasking
    {
        public static void Tasks()
        {
            Task task1 = new Task(() => Methods.GenerationElments());
            task1.Start();
        }
        public static class Methods
        {
            static int[] array1 = new int[10];
            static int[] array2 = new int[10];
            static int[] result = new int[10];
            static object locker = new object();

            public static void GenerationElments()
            {
                lock (locker)
                {
                    Random random = new Random();
                    for (int i = 0; i < array1.Length; i++)
                    {
                        array1[i] = random.Next(-10, 10);
                        array2[i] = random.Next(-10, 10);
                    }
                }
            }
            public static void SummaArray()
            {
                Console.WriteLine("First array");
                for (int i = 0; i < array1.Length; i++)
                {
                    Console.WriteLine(array1[i]);
                }
                Console.WriteLine("secod array");
                for (int i = 0; i < array2.Length; i++)
                {
                    Console.WriteLine(array2[i]);
                }
                Console.WriteLine("Summa array");
                for (int i = 0; i < result.Length; i++)
                {
                    result[i] = array1[i] + array2[i];
                    Console.WriteLine(result[i]);
                }
            }
        }
}
