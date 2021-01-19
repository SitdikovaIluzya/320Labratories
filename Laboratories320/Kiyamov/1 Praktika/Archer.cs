using System;
using System.Collections.Generic;
using System.Text;

namespace Laboratories320.Kiyamov._1_Praktika
{
    class Archer : IToDamageble
    {
        public int Damage { get; set; }
        public Archer(string Name, int hp,int Damage) : base(Name, hp)
        {
            this.Damage = Damage;
        }
    }
}
