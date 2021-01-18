using System;
using System.Collections.Generic;
using System.Text;

namespace Laboratories320
{
    class WatchingTower : CharacteristicBuilding, IBuilding
    {
        public WatchingTower(int defence)
        {
            _defence = defence;
        }
        public void Collabaration()
        {
            Console.WriteLine("WatchingTower collabaration");
        }
    }
}
