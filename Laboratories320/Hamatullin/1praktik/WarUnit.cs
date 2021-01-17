using Laboratories320.Hamatullin._1praktik.Interface;
using System;
using System.Collections.Generic;
using System.Text;

namespace Laboratories320.Hamatullin._1praktik
{
    abstract class WarUnit : Unit, IMoveable
    {
        public WarUnit(string Name, int Hp, int Speed) : base(Name, Hp)
        {
            this.Speed = Speed;
        }

        public int Speed { get; set; }

        public void Carry(Unit unit)
        {
            if (unit.Hp < 20)
            {
                Console.WriteLine($"{Name} тащит {unit.Name} в укрытие");
            }
            else
            {
                Console.WriteLine($"{Name} тащит {unit.Name}");
            }
            
        }

        public void Move()
        {
            Console.WriteLine("Ходит");
        }

    }
}
