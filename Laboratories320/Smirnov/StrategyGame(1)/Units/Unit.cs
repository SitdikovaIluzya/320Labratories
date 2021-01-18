using System;
using System.Collections.Generic;
using System.Text;

namespace Laboratories320.Smirnov.StrategyGame_1_.Units
{
    abstract class Unit
    {
        internal string Name { get; }
        internal int Health { get; set; }
        public Unit(string name, int health)
        {
            Name = name;
            Health = health;
        }
    }
}
