using Laboratories320.Dyubanov.StrategyGame;
using System;

namespace Laboratories320
{
    class Program
    {
        static void Main(string[] args)
        {
            Attacker att1 = new Attacker("att1", 50, 100);
            Attacker att2 = new Attacker("att2", 5, 80);
            Archer arc1 = new Archer("arc1", 30, 50);
            Citadel cit1 = new Citadel("cit1", 30, 50);
            Defender def1 = new Defender("def1", 50, 80);

            att1.SendMessage();
            def1.DamageEnemy(att2);
        }
    }
}
