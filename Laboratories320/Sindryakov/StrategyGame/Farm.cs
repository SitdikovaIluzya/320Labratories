using System;
using System.Collections.Generic;
using System.Text;

namespace Laboratories320.Sindryakov.StrategyGame
{
    class Farm : UnitBuilding, ICureYourUnit, IWork
    {
        public int StorageSpace { get; set; } //место для хранения
        public int MiningSpeed { get; set; } //скорость добычи

        public void Cure()
        {
            throw new NotImplementedException();
        }

        public void IWork()
        {
            throw new NotImplementedException();
        }

        //public Farm(string name, int health, int numberofcharges) : base(name, health)
        //{

        //}
    }
}
