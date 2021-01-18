using System;
using System.Collections.Generic;
using System.Text;

namespace Laboratories320.Sindryakov.StrategyGame
{
    class Barracks : WorkerUnit, ICureYourUnit
    {
        public int StorageSpace { get; set; } //место для хранения        
        public int PlaceForWarriors { get; set; } //место для хранения

        public void Cure()
        {
            throw new NotImplementedException();
        }
    }
}