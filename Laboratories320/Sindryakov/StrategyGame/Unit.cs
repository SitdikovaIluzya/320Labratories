using System;
using System.Collections.Generic;
using System.Text;

namespace Laboratories320.Sindryakov.StrategyGame
{
    abstract class Unit
    {
        public string Name { get; set; }
        public double Healt { get; set; }
        public Unit(string name, double healt)
        {

        }
    }
}
