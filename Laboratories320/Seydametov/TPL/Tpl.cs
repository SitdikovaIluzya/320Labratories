using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace Laboratories320.Seydametov.TPL
{
    class Tpl
    {
        public static void tpl()
        {
            Task task1 = new Task(() => Console.WriteLine("+"));
            task1.Start();

            Task task2 = new Task(() => Console.WriteLine("-"));
            task2.Start();
        }
    }
}
