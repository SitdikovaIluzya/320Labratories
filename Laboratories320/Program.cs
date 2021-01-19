using System;

namespace Laboratories320.Tikhonov.Strategy_game
{
    class Program
    {
        static void Main(string[] args)
        {
            Iwizard wizard = new ArmyClass(10, 11, 12, 13);
            wizard.move();
            Console.WriteLine(wizard.HitPoints);
            
        }
    }
}
