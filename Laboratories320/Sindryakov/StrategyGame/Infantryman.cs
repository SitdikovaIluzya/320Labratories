using System;
using System.Collections.Generic;
using System.Text;

namespace Laboratories320.Sindryakov.StrategyGame
{
    class Infantryman : WarUnit, IDestroy, ICureYourUnit
    {
        public int Force { get; set; } //сила
        public int Speed { get; set; } //скорость 
        public int AttackSpeed { get; set; } //скорость атаки

        public void Cure()
        {
            throw new NotImplementedException();
        }

        public void Destroy()
        {
            throw new NotImplementedException();
        }
        //public Infantryman(string name,int health, int numberofcharges) : base(name, health)
        //{

        //}
    }
}
