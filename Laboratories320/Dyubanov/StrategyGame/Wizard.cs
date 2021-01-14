using System;
using System.Collections.Generic;
using System.Text;

namespace Laboratories320.Dyubanov.StrategyGame
{
    class Wizard : Unit, IMove, IPower, ISendMessage, IAddPower
    {
        public Wizard(string UnitName, int UnitHealth, int UnitProtection) : base(UnitName, UnitHealth, UnitProtection)
        {
        }

        public int Power { get => 20; set => throw new NotImplementedException(); }

        public void AddPower(IPower teammate)
        {
            teammate.Power += this.Power;
            throw new NotImplementedException();
        }

        public void Move()
        {
            throw new NotImplementedException();
        }

        public void SendMessage()
        {
            throw new NotImplementedException();
        }
    }
}
