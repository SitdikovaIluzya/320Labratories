using Laboratories320.Hamatullin._1praktik.Interface;
using System;
using System.Collections.Generic;
using System.Text;

namespace Laboratories320.Hamatullin._1praktik
{
    class DefensiveTower : UnitBuilding,IToDamageble,IShootable
    {
        public DefensiveTower(string Name,int Hp,int Width,int Length,int Damage) : base (Name,Hp,Width,Length)
        {
            this.Damage = Damage;
        }

        public int Damage { get; set; }
        public int Range { get; } = 20;

        public void Shoot(Unit unit)
        {
            Console.WriteLine($"Выстрелил по {unit.Name} и нанес = {Damage}");

            if (unit.Hp < Damage)
            {
                unit.Hp = 0;
                Unit.Destruction(unit);
            }
            else
            {
                unit.Hp -= Damage;
            }
        }
    }
}
