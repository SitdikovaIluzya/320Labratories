using System;
using System.Collections.Generic;
using System.Text;

namespace Laboratories320.Zakirov._1Praktika
{
    abstract class WorkerUnit : Unit
    {
        public int SpeedConstruction { get; set; } //скорость строительства

        public WorkerUnit(string Name, int Health, int SpeedConstruction) : base(Name, Health)
        {
            this.SpeedConstruction = SpeedConstruction;
        }
    }
}
