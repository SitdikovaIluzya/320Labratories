using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace Laboratories320.Saifetdinov.Prac5
{
    class Taskings
    {
        public static void Task()
        {
            Task task1 = new Task(ArrayMethods.GenerationElementsArray);
            Task task2 = task1.ContinueWith(task1 => ArrayMethods.Multication());
            Task task3 = task2.ContinueWith(task2 => ArrayMethods.ParityNumber());
            task1.Start();
            task2.Wait();
            task3.Wait();
            Console.ReadKey();
        }
    }
}
