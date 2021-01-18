using Laboratories320.Smirnov.StrategyGame_1_.Units.Units_buildings;
using System;
using System.Collections.Generic;
using System.Text;

namespace Laboratories320.Smirnov.StrategyGame_1_.Interfaces
{
    interface IRestore
    {
        public void Restore(ArchersTower archer);
        public void Restore(Wall wall);
        public void Restore(WitchesTower witcher);
    }
}
