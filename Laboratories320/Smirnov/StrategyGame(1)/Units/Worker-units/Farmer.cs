using Laboratories320.Smirnov.StrategyGame_1_.Interfaces;
using Laboratories320.Smirnov.StrategyGame_1_.Units.Units_buildings;
using System;
using System.Collections.Generic;
using System.Text;

namespace Laboratories320.Smirnov.StrategyGame_1_.Units.Worker_units
{
    class Farmer : Unit, IMove, IRestore
    {
        public Farmer(string name, int health) : base(name, health) { }

        public void Move()
        {
            throw new NotImplementedException();
        }

        public void Restore(ArchersTower archer)
        {
            throw new NotImplementedException();
        }

        public void Restore(Wall wall)
        {
            throw new NotImplementedException();
        }

        public void Restore(WitchesTower witcher)
        {
            throw new NotImplementedException();
        }
    }
}
