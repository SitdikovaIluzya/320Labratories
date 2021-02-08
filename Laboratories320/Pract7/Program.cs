using System;
using Laboratories320.Pract7;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            //Console.WriteLine("Leave hope behind all who enters here...");
            //Console.WriteLine();

            //ThreadLocker thr = new ThreadLocker();
            //thr.Start();

            //ThreadLockerTask task = new ThreadLockerTask();
            //task.Start();

            Heroes heroes = new Heroes
            {
                HeroesName = "Nolly",
                Health = 150
            };

            //Heroes.HeroesInsert(heroes).GetAwaiter().GetResult();

            Heroes heroes1 = new Heroes
            {
                HeroesName = "Bill",
                Health = 99
            };
            //Hero.HeroInsert(hero1).GetAwaiter().GetResult();
            Heroes.HeroesNameResault("H", heroes1).GetAwaiter().GetResult();
        }
    }
}
