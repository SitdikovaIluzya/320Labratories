using Laboratories320.Hamatullin._1praktik.Interface;
using System;
using System.Collections.Generic;
using System.Text;

namespace Laboratories320.Hamatullin._1praktik
{
    class Warrior : WarUnit, IStrikeable
    {
        public int Damage { get; set; }

        public Warrior(string Name, int Hp, int Speed, int Armor, int Damage) : base(Name, Hp, Speed, Armor)
        {
            this.Damage = Damage;
        }

        public void Strike(Unit unit)
        {
            Console.WriteLine($"Ударил по {unit.Name} и нанес = {Damage}");

            if (unit.Hp < Damage)
            {
                Unit.Destruction(unit);
            }
            else
            {
                unit.Hp -= Damage;
            }
        }
    }
}
