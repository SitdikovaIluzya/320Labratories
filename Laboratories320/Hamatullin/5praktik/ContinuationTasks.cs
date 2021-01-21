using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace Laboratories320.Hamatullin._5praktik
{
    class ContinuationTasks
    {
        static int[] mass = new int[20];
        static int product = 1;

        public void Gen()
        {
            Random rnd = new Random();
            for (int i = 0; i < mass.Length; i++)
            {
                mass[i] = rnd.Next(10, 20);
            }
        }
        public void Product()
        {
            
        }
    }
}
