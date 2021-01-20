using System;
using System.Collections.Generic;
using System.Text;

namespace Laboratories320.Tikhonov.Strategy_game
{
    public class BuildingClass : Itower, IholyObelisk, Ifarm
    {
        int damage;
        int hitPoints;
        public BuildingClass(int hitPoints, int damage)
        {
            this.Damage = damage;
            this.HitPoints = hitPoints;
        }

        public BuildingClass(int hitPoints)
        {

            this.HitPoints = hitPoints;

        }

        public int Damage { get { return (damage); } set { damage = value; } }
        public int HitPoints { get { return (hitPoints); } set { hitPoints = value; } }



        public void range_attak(IbaseUnit unit)
        {
            unit.HitPoints -= this.damage;
        }

        public void heal_ally(IbaseUnit unit)
        {
            unit.HitPoints += this.damage;
        }

        public void produceCrops()
        {
            Console.WriteLine("Producing Crops");
        }
    }
}
