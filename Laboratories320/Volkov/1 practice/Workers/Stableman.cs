using Laboratories320.Volkov._1_practice.Interfaces;
using System;
using System.Collections.Generic;
using System.Text;

namespace Laboratories320.Volkov._1_practice.Workers
{
    public class Stableman : Unit, IMoveable, IWorkable, ISellable 
    {
        public Stableman(string name, int health) : base(name, health) { }

        public void Move()
        {
            throw new NotImplementedException();
        }

        public void Sell()
        {
            throw new NotImplementedException();
        }

        public void Work()
        {
            throw new NotImplementedException();
        }
    }
}
