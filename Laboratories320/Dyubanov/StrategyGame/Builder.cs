using System;
using System.Collections.Generic;
using System.Text;

namespace Laboratories320.Dyubanov.StrategyGame
{
    class Builder : Unit, IPower, IMove, ISendMessage, IRepairBuild
    {
        public Builder(string UnitName, int UnitHealth, int UnitProtection) : base(UnitName, UnitHealth, UnitProtection)
        {
        }

        public int Power { get => 50; set => throw new NotImplementedException(); }

        public void Move()
        {
            Console.WriteLine(this.Name + ": Moving");
        }

        public void RepairBuild(Unit build)
        {
            build.Health += this.Power;
            throw new NotImplementedException();
        }

        public void SendMessage()
        {
            Console.WriteLine(this.Name + ": Ready for battle!");
        }
    }
}
