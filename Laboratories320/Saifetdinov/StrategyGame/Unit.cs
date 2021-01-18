using System;
using System.Collections.Generic;
using System.Text;

namespace Laboratories320.Saifetdinov.StrategyGame
{
    class Unit : BasicInformation, IMovementOfThePointer, IAttack
    {
        public int Damage { get; set; }
        public int Speed { get; set; }

        public void Attack()
        {
            Console.WriteLine("For the Motherland!!!");
        }

        public void MovementOfThePointer()
        {
            Console.WriteLine("Yes I`m coming I`m coming");
        }
    }
}
