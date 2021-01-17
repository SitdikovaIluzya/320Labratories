using Laboratories320.Hamatullin._1praktik.Interface;
using System;
using System.Collections.Generic;
using System.Text;

namespace Laboratories320.Hamatullin._1praktik
{
    abstract class WarUnit : Unit, IMoveable
    {
        public int Armor { get; set; }
        public int Speed { get; set; }
        public WarUnit(string Name, int Hp, int Speed, int Armor) : base(Name, Hp)
        {
            this.Speed = Speed;
            this.Armor = Armor;
        }



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
