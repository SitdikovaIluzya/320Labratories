using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace Laboratories320.Pract4
{
    class Thread2
    {
        static int[] num1 = new int[10];
        static int[] num2 = new int[10];
        static int[] resl = new int[10];
       

        public static void Tasks()
        {
            Task tk = new Task(() => Generate());
            Task tk1 = new Task(() => Summa());
            tk.Start();
            tk1.Start();
            tk.Wait();
        }

        public static void Generate()
        
            
            {
                Random rand = new Random();
                for (int i = 0; i < num1.Length; i++)
                {
                    num1[i] = rand.Next(10);
                    Console.WriteLine(num1[i] + " ");
                }

                for (int i = 0; i < num2.Length; i++)
                {
                    num2[i] = rand.Next(10);
                    Console.WriteLine(num2[i] + " ");
                }

            
        }

        public static void Summa()
        {
           
            for (int i = 0; i < resl.Length; i++)
            {
                resl[i] = num1[i] + num2[i];
                Console.WriteLine(resl[i] + " ");

            }
        }
    }
}
