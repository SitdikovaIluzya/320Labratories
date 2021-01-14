using Laboratories320.Hamatullin._1praktik.Interface;
using System;
using System.Collections.Generic;
using System.Text;

namespace Laboratories320.Hamatullin._1praktik
{
    abstract class WarUnit : Unit, IMoveable
    {
        public WarUnit(string Name, int Hp, int Speed) : base(Name, Hp)
        {
            this.Speed = Speed;
        }

        public int Speed { get; set; }

        public void Carry()
        {
            throw new NotImplementedException();
        }

        public void Move()
        {
            throw new NotImplementedException();
        }

        public void Move(Unit unit)
        {
            throw new NotImplementedException();
        }
    }
}
