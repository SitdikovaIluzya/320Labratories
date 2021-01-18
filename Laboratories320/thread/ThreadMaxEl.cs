using System;
using System.Collections.Generic;
using System.Text;

namespace Laboratories320.thread
{
    class ThreadMaxEl
    {
        public static void Max(double[] arr)
        {
            double max;
            for(int i = 1; i < arr.Length; i++)
            {
                if(arr[i]>arr[i-1])
                {
                    max = arr[i];
                }
            }
        }
    }
}

