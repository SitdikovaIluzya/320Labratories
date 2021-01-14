using System;
using System.Collections.Generic;
using System.Text;

namespace Laboratories320.Dyubanov.StrategyGame
{
    class Archer : Unit, IDamageEnemy, IMove, IPower, ISendMessage
    {
        public Archer(string UnitName, int UnitHealth, int UnitProtection) : base(UnitName, UnitHealth, UnitProtection)
        { 
        }
        public int Power { get => 25; set => throw new NotImplementedException(); }

        public void DamageEnemy(Unit enemy)
        {
            enemy.Health = enemy.Health - (this.Power - (enemy.Protection / 2));
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
    

