using System;
using System.Collections.Generic;
using System.Text;

namespace Laboratories320.Tikhonov.Strategy_game
{
    using System;
    using System.Collections.Generic;
    using System.Text;

    namespace Laboratories320.Tikhonov.Strategy_game
    {
        public class ServantClass : Ipriest, Iminer, Icarrier
        {
            int damage;
            int hitPoints;
            int speed;
            public ServantClass(int hitPoints, int damage, int speed)
            {
                this.Damage = damage;
                this.HitPoints = hitPoints;
                this.Speed = speed;
            }

            public ServantClass(int hitPoints, int speed)
            {

                this.HitPoints = hitPoints;
                this.Speed = speed;


            }

            public int Damage { get { return (damage); } set { damage = value; } }
            public int HitPoints { get { return (hitPoints); } set { hitPoints = value; } }
            public int Speed { get { return (speed); } set { speed = value; } }

            public void heal_ally(IbaseUnit unit)
            {
                unit.HitPoints += this.damage;
            }

            public void move()
            {
                System.Console.WriteLine("moving at a speed of " + this.Speed);
            }

            public void mine()
            {
                System.Console.WriteLine("mining");
            }

            public void carry()
            {
                System.Console.WriteLine("carring")            }
        }
        
    }

}
