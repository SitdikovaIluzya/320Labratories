using System;
using System.Collections.Generic;
using System.Text;

namespace Laboratories320.Musin.StrategyGame
{
    class WorkerUnit : Unit, IWorkable, IMoveable
    {
        public override int Health { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }
        public int X { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }
        public int Y { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }

        public void Move()
        {
            throw new NotImplementedException();
        }

        public void Work()
        {
            throw new NotImplementedException();
        }
    }
}
