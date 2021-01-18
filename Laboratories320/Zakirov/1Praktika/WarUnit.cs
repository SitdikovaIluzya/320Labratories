using System;
using System.Collections.Generic;
using System.Text;

namespace Laboratories320.Zakirov._1Praktika
{
    abstract class WarUnit : Unit, IWalk
    {
        public int AttackSpeed { get; set; } //скорость атаки
        public int MovementSpeed { get; set; } //скорость передвижения
        public int Speed { get; set; }

        public WarUnit(string Name, int Health, int AttackSpeed, int MovementSpeed, int Speed) : base(Name, Health)
        {
            this.AttackSpeed = AttackSpeed;
            this.MovementSpeed = MovementSpeed;
            this.Speed = Speed;
        }

        public void Walk()
        {
            Console.WriteLine("Воин ходит");
        }
    }
}
