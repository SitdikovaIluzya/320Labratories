using Laboratories320.Hamatullin._1praktik.Interface;
using System;
using System.Collections.Generic;
using System.Text;

namespace Laboratories320.Hamatullin._1praktik
{
    class DefensiveTower : UnitBuilding, IShootable
    {

        public int Damage { get; set; }
        public int Range { get; } = 20;

        public DefensiveTower(string Name, int Hp, int Width, int Length, int Damage) : base(Name, Hp, Width, Length)
        {
            this.Damage = Damage;
        }

        public void Shoot(Unit unit)
        {
            Console.WriteLine($"Выстрелил по {unit.Name} и нанес = {Damage}");

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
