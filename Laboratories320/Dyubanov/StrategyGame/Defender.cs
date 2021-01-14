using System;
using System.Collections.Generic;
using System.Text;

namespace Laboratories320.Dyubanov.StrategyGame
{
    class Defender : Unit, IDamageEnemy, IMove, IPower, ISendMessage
    {
        public Defender(string UnitName, int UnitHealth, int UnitProtection) : base(UnitName, UnitHealth, UnitProtection)
        {
        }

        public int Power => 10;

        public void DamageEnemy(Unit enemy)
        {
            enemy.Health -= this.Power; 
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
