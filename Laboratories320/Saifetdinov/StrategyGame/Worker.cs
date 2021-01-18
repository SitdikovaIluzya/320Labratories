using System;
using System.Collections.Generic;
using System.Text;

namespace Laboratories320.Saifetdinov.StrategyGame
{
    class Worker : BasicInformation, IMovementOfThePointer
    {
        public int OpeningHours { get; set; }

        public void MovementOfThePointer()
        {
            Console.WriteLine("will give boots?");
        }
    }
}
