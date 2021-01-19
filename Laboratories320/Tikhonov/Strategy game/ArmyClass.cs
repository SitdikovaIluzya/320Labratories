using System;
using System.Collections.Generic;
using System.Text;

namespace Laboratories320.Tikhonov.Strategy_game
{
    public class ArmyClass : Ipaladin, Isoldier, Iwizard
    {
        int armorClass;
        int speed;
        int damage;
        int hitPoints;
        public ArmyClass(int hitPoints, int armorClass, int speed, int damage) 
        {
            this.ArmorClass = armorClass;
            this.Speed = speed;
            this.Damage = damage;
            this.HitPoints = hitPoints;
        }

        public ArmyClass(int hitPoints, int speed, int damage) 
        {

            this.Speed = speed;
            this.Damage = damage;
            this.HitPoints = hitPoints;

        }

        public int ArmorClass { get { return (armorClass); } set { armorClass = value; } }
        public int Speed { get { return (speed); } set { speed = value; } }        
        public int Damage { get { return (damage); } set { damage = value; } }
        public int HitPoints { get { return (hitPoints); } set { hitPoints = value; } }


        public void melee_attack(IbaseUnit unit)
        {
            unit.HitPoints -= this.damage;
        }

        public void move()
        {
            System.Console.WriteLine("moving at a speed of " + this.Speed);
        }

        public void range_attak(IbaseUnit unit)
        {
            unit.HitPoints -= this.damage;
        }

        public void heal_ally(IbaseUnit unit)
        {
            unit.HitPoints += this.damage;
        }
    }
}
