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
            Task task1 = Task.Factory.StartNew(() => MethodsArray.Methods.GenerationElments());
            Task task2 = Task.Factory.StartNew(() => MethodsArray.Methods.SummaArray());
            task2.Wait();
        }
    }
}
