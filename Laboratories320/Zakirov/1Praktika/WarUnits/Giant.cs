using System;
using System.Collections.Generic;
using System.Text;

namespace Laboratories320.Zakirov._1Praktika
{
    class Giant :WarUnit //гигант
    {
        public int DamageDone { get; set; } //нанесенный урон

        public Giant(string Name, int Health, int AttackSpeed, int MovementSpeed, int Speed, int DamageDone) : base(Name, Health, AttackSpeed, MovementSpeed, Speed)
        {
            this.DamageDone = DamageDone;
        }

        public void Assault()
        {
            Console.WriteLine("Герой напал");
        }

        public void Destroy()
        {
            Console.WriteLine("Герой уничтожил");
        }
    }
}
