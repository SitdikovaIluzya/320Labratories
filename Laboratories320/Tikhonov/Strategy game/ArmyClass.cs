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

        public ArmyClass(int hitPoints, int armorClass, int speed, int damage) 
        {
            this.ArmorClass = armorClass;
            this.Speed = speed;
            this.Damage = damage;
        }

        public ArmyClass(int hitPoints, int speed, int damage) 
        {

            this.speed = speed;
            this.damage = damage;
        }

        public int ArmorClass { get { return (armorClass); } set { armorClass = value; } }
        public int Speed { get { return (speed); } set { speed = value; } }        
        public int Damage { get { return (damage); } set { damage = value; } }

        public int hitPoints { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }

        //public void heal_ally(IbaseUnit ally)
        //{
        //    ally.hitPoints += this.damage;
        //}

        public void melee_attack()
        {
            throw new NotImplementedException();
        }

        public void move()
        {
            throw new NotImplementedException();
        }

        public void range_attak()
        {
            throw new NotImplementedException();
        }

        public void heal_ally(IbaseUnit ally)
        {
            throw new NotImplementedException();
        }
    }
}
