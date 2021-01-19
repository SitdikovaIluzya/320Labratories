using System;
using System.Collections.Generic;
using System.Text;

namespace Laboratories320.Tikhonov.Strategy_game
{
    abstract public class BaseUnit
    {
        public BaseUnit(int hitPoints)
        {
            this.hitPoints = hitPoints;
        }

        public int hitPoints { get { return (hitPoints); } set { hitPoints = value; } }
    }
}
