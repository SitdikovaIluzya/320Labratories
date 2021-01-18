using System;
using System.Collections.Generic;
using System.Text;

namespace Laboratories320.Musin.StrategyGame
{
    class Guildhall : UnitBuilding
    {
        public override int Health { get; set; } = 1500;
        public int CountUnit { get; set; } = 15;
    }
}
