using System;
using System.Collections.Generic;
using System.Text;

namespace Laboratories320.Dyubanov.StrategyGame
{
    class Wizard : Unit, IMove, IPower, IMana, ISendMessage, IAddPower
    {
        public Wizard(string UnitName, int UnitHealth, int UnitProtection) : base(UnitName, UnitHealth, UnitProtection)
        {
        }

        public int Power { get => 20; set => throw new NotImplementedException(); }
        public int Mana { get => 100; set => throw new NotImplementedException(); }

        public void AddPower(IPower teammate)
        {
            teammate.Power += this.Power;
            this.Mana -= this.Power;
            throw new NotImplementedException();
        }

        public void Move()
        {
            Console.WriteLine(this.Name + ": Moving");
            throw new NotImplementedException();
        }

        public void SendMessage()
        {
            Console.WriteLine(this.Name + ": Ready for battle!");
        }
    }
}
