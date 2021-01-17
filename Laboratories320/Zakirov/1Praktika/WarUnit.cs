using System;
using System.Collections.Generic;
using System.Text;

namespace Laboratories320.Zakirov._1Praktika
{
    abstract class WarUnit : Unit
    {
        public int AttackSpeed { get; set; } //скорость атаки
        public int MovementSpeed { get; set; } //скорость передвижения
        
        public WarUnit(string Name, int Health, int AttackSpeed, int MovementSpeed) : base(Name, Health)
        {
            this.AttackSpeed = AttackSpeed;
            this.MovementSpeed = MovementSpeed;
        }
    }
}
