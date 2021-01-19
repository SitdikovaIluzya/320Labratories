using System;
using System.Collections.Generic;
using System.Text;
using System.Threading;
using Laboratories320.Kiyamov.ThreadLocker;

namespace Laboratories320.Kiyamov.ThreadLocker
{
    class ThreadLock
    {
        int[] array = new int[5];
        static int[] Mass1 = new int[5];
        static int[] Mass2 = new int[5];
        static int[] resuilts = new int[5];


        
        
       
        public void MassiveGenarate()
        {
      
            Random rnd = new Random();
            for (int i = 0; i < array.Length; i++)
            {
                array[i] = rnd.Next(1, 20);
            }
            Console.WriteLine("Massive : " + Mass1);
            foreach (var item in array)
            {
                Console.WriteLine(item + " ");
                
            }
      
        }

    }

}


    


