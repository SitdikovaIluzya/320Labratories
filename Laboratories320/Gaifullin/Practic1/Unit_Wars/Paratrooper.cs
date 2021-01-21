using System;
using System.Collections.Generic;
using System.Text;

namespace Laboratories320.Gaifullin
{
    class Paratrooper :Warr // Десант
    {
        public int DamageDone { get; set; } //нанесенный урон

        public Paratrooper(string Name, int Health, int AttackSpeed, int MovementSpeed) : base(Name, Health, AttackSpeed, MovementSpeed)
        {
            this.DamageDone = DamageDone;
        }                

        public void Destroy()
        {
            Console.WriteLine("Герой уничтожил");
        }
    }
}
