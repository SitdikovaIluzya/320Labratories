using System;
using System.Collections.Generic;
using System.Text;

namespace Laboratories320.Saifetdinov.StrategyGame
{
    class Builder : Worker
    {
        public int WorkExperience { get; set; }

        public void BuildABuilding()
        {
            Console.WriteLine("I'm going to build");
        }

        public void RestoreBuilding()
        {
            Console.WriteLine("I'm running to restore");
        }
    }
}
