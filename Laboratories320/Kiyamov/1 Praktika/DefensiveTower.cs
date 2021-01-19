using System;
using System.Collections.Generic;
using System.Text;

namespace Laboratories320.Kiyamov._1_Praktika
{
    class DefensiveTower : UnitBuilding,IToDamageble
    {
        public int Damage { get; set; }
        public DefensiveTower(string Name, int Hp, int Width,int Damage) : base(Name, Hp, Width)
        {
            this.Damage = Damage;
        }
    }
}
