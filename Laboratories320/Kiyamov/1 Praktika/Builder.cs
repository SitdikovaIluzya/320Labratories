using System;
using System.Collections.Generic;
using System.Text;

namespace Laboratories320.Kiyamov._1_Praktika
{
    class Builder : IFix

    { 
        public void RepairBuild(UnitBuilding unitBuilding)
        {
            unitBuilding.Hp += 20;
            Console.WriteLine("Fixed 20 HP");
        }
    }
}
