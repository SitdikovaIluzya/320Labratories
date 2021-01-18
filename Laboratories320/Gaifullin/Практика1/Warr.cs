using System;
using System.Collections.Generic;
using System.Text;

namespace Laboratories320.Gaifullin
{
    abstract class Warr : Units
    {
        public int AttackSpeed { get; set; } //скорость атаки
        public int MovementSpeed { get; set; } //скорость передвижения
       

        public Warr(string Name, int Health, int AttackSpeed, int MovementSpeed) : base(Name, Health)
        {
            this.AttackSpeed = AttackSpeed;
            this.MovementSpeed = MovementSpeed;          
        }
    }
}
