using System;
using System.Collections.Generic;
using System.Text;

namespace Laboratories320
{
    interface IWorker
    {
        public void Cook();
        public void Move();
        public void Eat();
    }
    interface IWarrior
    {
        public void Grenade();
        public void Axe();

    }
    interface IBuilding
    {
        public void Collabaration();
    }
}
