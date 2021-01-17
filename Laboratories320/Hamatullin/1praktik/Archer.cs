using Laboratories320.Hamatullin._1praktik.Interface;
using System;
using System.Collections.Generic;
using System.Text;

namespace Laboratories320.Hamatullin._1praktik
{
    class Archer : WarUnit,IShootable,IToDamageble
    {
        public int Ammunition { get; set; } = 50;
        public int Range { get; } = 10;
        public int Damage { get; set; }

        public Archer(string Name,int Hp,int Speed, int Armor,int Damage) : base (Name,Hp,Speed,Armor)
        {
            this.Damage = Damage;
        }

        public void Shoot(Unit unit)
        {
            Ammunition -= 1;
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

        public void ReplenishAmmunition(Armory armory)
        {
            if (armory.NumberAmmunition > 50)
            {
                Console.WriteLine("Пополнение стрел");
                for (int i = 0; i < Ammunition; i++)
                {
                    Ammunition += 1;
                }
            }
            else
            {
                Console.WriteLine($"Нехватка стрел в {armory.Name}");
            }
        }
    }
}
