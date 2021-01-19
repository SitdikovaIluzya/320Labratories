using System;
using System.Collections.Generic;
using System.Text;

namespace Laboratories320.Saifetdinov.StrategyGame
{
    class Tank : Unit
    {
        public int Protection { get; set; }

        public void ToProtect()
        {
            Console.WriteLine("To raise their shields");
        }
    
    }
}
