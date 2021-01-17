using System;
using System.Collections.Generic;
using System.Text;

namespace Laboratories320.Hamatullin._1praktik
{
    class Armory : UnitBuilding
    {
        public int NumberAmmunition { get; set; }
        public Armory(string Name,int Hp,int Width,int Length, int NumberAmmunition) : base (Name,Hp,Width,Length)
        {
            this.NumberAmmunition = NumberAmmunition;
        }

    }
}
