using Laboratories320.Hamatullin._1praktik.Interface;
using System;
using System.Collections.Generic;
using System.Text;

namespace Laboratories320.Hamatullin._1praktik
{
    class Archer : WarUnit,IShootable,IToDamageble
    {
        public Archer(string Name,int Hp,int Speed) : base (Name,Hp,Speed)
        {

        }

        public int Ammunition { get; } = 50;

        public int Range { get; } = 10;

        public int Damage { get; } = 40;

        public void Shoot(Unit unit)
        {
            Console.WriteLine($"Выстрелил по {unit.Name} и нанес = {Damage}");
            
            if (unit.Hp < Damage)
            {
                unit.Hp = 0;
                Console.WriteLine($"{unit.Name} умер");
            }
            else
            {
                unit.Hp -= Damage;
            }
        }
    }
}
