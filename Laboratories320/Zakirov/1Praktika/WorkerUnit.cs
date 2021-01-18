using System;
using System.Collections.Generic;
using System.Text;

namespace Laboratories320.Zakirov._1Praktika
{
    abstract class WorkerUnit : Unit, IWalk
    {
        public int SpeedConstruction { get; set; } //скорость строительства
        public int Speed { get; set; }

        public WorkerUnit(string Name, int Health, int SpeedConstruction, int Speed) : base(Name, Health)
        {
            this.SpeedConstruction = SpeedConstruction;
            this.Speed = Speed;
        }

        public void Walk()
        {
            Console.WriteLine("Рабочий ходит");
        }
    }
}
