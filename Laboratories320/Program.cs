using Laboratories320.Dyubanov.StrategyGame;
using System;

namespace Laboratories320
{
    class Program
    {
        static void Main(string[] args)
        {
            Atacker att1 = new Atacker("att1", 50, 100);
            Atacker att2 = new Atacker("att2", 70, 80);
            Archer arc1 = new Archer("arc1", 30, 50);
            Citadel cit1 = new Citadel("cit1", 30, 50);

            att1.SendMessage();
            att1.DamageEnemy(att2);
        }
    }
}
