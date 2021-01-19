using System;
using System.Threading;
using Laboratories320.Lab2;

namespace Laboratories320
{
    class Program
    {

        static void Main(string[] args)
        {
            Random rnd = new Random();
            int[] arr = new int[10];
            foreach (var item in arr)
            {
                arr[1] = rnd.Next(-10, 20);
            }
            Threading th = new Threading(arr);
            th.Start();
        }

    }
}







        
    




    

