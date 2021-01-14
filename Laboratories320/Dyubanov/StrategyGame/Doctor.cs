using System;
using System.Collections.Generic;
using System.Text;

namespace Laboratories320.Dyubanov.StrategyGame
{
    class Doctor : Unit, IMove, IPower, ISendMessage, IHealTeammate
    {
        public Doctor(string UnitName, int UnitHealth, int UnitProtection) : base(UnitName, UnitHealth, UnitProtection)
        {
        }

        public int Power { get => 50; set => throw new NotImplementedException(); }

        public void HealTeammate(Unit teammate)
        {
            teammate.Health += this.Power;
            throw new NotImplementedException();
        }

        public void Move()
        {
            Console.WriteLine(this.Name + ": Moving");
        }

        public void SendMessage()
        {
            Console.WriteLine(this.Name + ": Ready for battle!");
        }
    }
}
