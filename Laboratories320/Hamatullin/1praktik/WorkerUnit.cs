using Laboratories320.Hamatullin._1praktik.Interface;
using System;
using System.Collections.Generic;
using System.Text;

namespace Laboratories320.Hamatullin._1praktik
{
    abstract class WorkerUnit : Unit, IMoveable
    {
        public int Speed { get; set; }

        public WorkerUnit(string Name, int Hp, int Speed) : base(Name, Hp)
        {
            this.Speed = Speed;
        }
        public void Carry(Unit unit)
        {
            Console.WriteLine($"{Name} тащит {unit.Name} в укрытие");
        }

        public void Move()
        {
            Console.WriteLine("Ходит");
        }
    }
}
