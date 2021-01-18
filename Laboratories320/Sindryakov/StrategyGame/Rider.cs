using System;
using System.Collections.Generic;
using System.Text;

namespace Laboratories320.Sindryakov.StrategyGame
{
    class Rider : WarUnit, IDestroy, ICureYourUnit
    {

        public int Force { get; set; } //сила
        public int Speed { get; set; } //скорость 

        public void Cure()
        {
            throw new NotImplementedException();
        }

        public void Destroy()
        {
            throw new NotImplementedException();
        }
        //public Rider(string name, int health, int numberofcharges) : base(name, health)
        //{

        //}
    }
}

