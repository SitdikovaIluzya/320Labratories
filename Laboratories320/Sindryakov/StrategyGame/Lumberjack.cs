using System;
using System.Collections.Generic;
using System.Text;

namespace Laboratories320.Sindryakov.StrategyGame
{
    class Lumberjack : WorkerUnit, ICureYourUnit, IWork
    {
        public int LiftingCapacity { get; set; } //грузоподъемность
        public int Speed { get; set; } //скорость
        public int WorkSpeed { get; set; } //скорость 

        public void Cure()
        {
            throw new NotImplementedException();
        }

        public void IWork()
        {
            throw new NotImplementedException();
        }
    }
}