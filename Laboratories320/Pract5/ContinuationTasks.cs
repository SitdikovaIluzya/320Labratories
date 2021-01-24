using System;
using System.Collections.Generic;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace Laboratories320.Pract5
{
    class ContinuationTasks
    {
        static int[] numb = new int[20];

        public static void Random()
        {
            for (int i = 0; i < numb.Length; i++)
            {
                Random random = new Random();
                numb[i] = random.Next(1, 20);
                Console.WriteLine("Random: " + numb[i]);
            }
        }

            public static void ProductOfAllElements()
           {

            int reslt = 1;
            for (int i = 0; i < numb.Length; i++)
            {
                reslt = numb[i] * reslt;
            }
            Console.WriteLine("ProductOfAllElements" + reslt);

        }
        public static void EventNumbers()
        {
            for (int i = 0; i < numb.Length; i++)
            {
                if (numb[i] % 2 == 0)
                {
                    Console.WriteLine("EvenNumbers " + numb[i]);
                }
            }
        }

        public static void ContTask()
        {
            Task tk = new Task(() => Random());
            Task tk1 = tk.ContinueWith(pr => ProductOfAllElements());
            Task tk2 = tk1.ContinueWith(even => EventNumbers());
            tk.Start();
            Task.WaitAll(tk, tk1, tk2);
  
          }
    
    }
}
