using Laboratories320.Dyubanov.StrategyGame;
using System;

namespace Laboratories320
{
    class Program
    {
        static void Main(string[] args)
        {
            Atacker att1 = new Atacker("att1", 50, 80);
            Atacker att2 = new Atacker("att2", 70, 80);

            att1.SendMessage();
            att1.DamageEnemy(att2);
        }
    }
}
