using System;
using System.Collections.Generic;
using System.Text;

namespace Laboratories320.Gaifullin
{
    class Mortar : Warr // Мортир
    {
        public int DamageDone { get; set; } // урон

        public Mortar(string Name, int Health, int DamageDone, int AttackSpeed, int MovementSpeed) : base(Name, Health, AttackSpeed, MovementSpeed)
        {
            this.DamageDone = DamageDone;
        }   

        public void Destroy()
        {
            Console.WriteLine("Герой уничтожил");
        }
    }
}
