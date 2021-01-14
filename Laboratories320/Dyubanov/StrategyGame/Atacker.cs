using System;
using System.Collections.Generic;
using System.Text;

namespace Laboratories320.Dyubanov.StrategyGame
{
    class Atacker : Unit, IDamageEnemy, IMove, IPower, ISendMessage
    {
        public Atacker(string UnitName, int UnitHealth, int UnitProtection) : base(UnitName, UnitHealth, UnitProtection)
        {
        }

        public int Power { get => 50; }

        public void DamageEnemy(Unit enemy)
        {
            enemy.Health = enemy.Health - (this.Power - (enemy.Protection / 5));
            Console.WriteLine(enemy.Health);
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
