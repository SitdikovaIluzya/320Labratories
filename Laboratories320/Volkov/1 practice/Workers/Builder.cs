using Laboratories320.Volkov._1_practice.Interfaces;
using System;
using System.Collections.Generic;
using System.Text;

namespace Laboratories320.Volkov._1_practice.Workers
{
    class Builder : Unit, IMoveable, IRestorable
    {
        public Builder(string name, int health) : base(name, health)
        {

        }

        public void Move()
        {
            throw new NotImplementedException();
        }

        public void Restore(Building.Catapult catapult)
        {
            throw new NotImplementedException();
        }

        public void Restore(Building.Ram ram)
        {
            throw new NotImplementedException();
        }

        public void Restore(Building.Scorion scorion)
        {
            throw new NotImplementedException();
        }
    }
}
