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

        public int Power { get => 10; set => throw new NotImplementedException(); }

        public void DamageEnemy(Unit enemy)
        {
            enemy.Health -= this.Power;
            Console.WriteLine(enemy.Health <= 0 ? enemy.Name + ": Dead" : enemy.Name + ": Got damage " + this.Power);
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
