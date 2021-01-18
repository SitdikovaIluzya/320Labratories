using System;
using System.Collections.Generic;
using System.Text;

namespace Laboratories320.thread
{
    class ThreadSum
    {
        public static void Sum(double [] arr)
        {
           
            double sum = 0;
            for (int i = 0; i < arr.Length;i++)
            {
                sum = sum + arr[i];
            }
        }
    }
}
