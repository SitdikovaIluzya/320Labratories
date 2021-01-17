using System;
using System.Collections.Generic;
using System.Text;

namespace Laboratories320.Hamatullin._1praktik
{
    abstract class Unit
    {
        public string Name { get; set; }
        public int Hp 
        {
            get
            {
                return Hp;
            }
            set
            {
                if (value < 0)
                {
                    Hp = 0;
                }
                else
                {
                    Hp = value;
                }
            }
        }
        public static void Destruction(Unit unit)
        {
            unit.Hp = 0;
            Console.WriteLine(unit.Name + " уничтожен");
        }

        public Unit(string Name, int Hp)
        {
            this.Name = Name;
            this.Hp = Hp;
        }
    }
}
