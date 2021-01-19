using System;

namespace Laboratories320.Tikhonov.Strategy_game
{
    class Program
    {
        static void Main(string[] args)
        {
            ArmyClass armyClass = new ArmyClass(10, 10, 10);
            Iwizard wizard = armyClass;
            wizard.heal_ally(wizard);
        }
    }
}
