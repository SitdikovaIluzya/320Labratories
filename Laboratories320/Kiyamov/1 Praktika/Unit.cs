using System;
using System.Collections.Generic;
using System.Text;

namespace Laboratories320.Kiyamov._1_Praktika
{
    class Unit
    {
        public int Hp { get; set; }
        public int Name { get; set; }
        public static void Destruction(Unit unit)
        {
            unit.Hp = 0;
            Console.WriteLine(unit.Name + " уничтожен");
        }

    }
}
