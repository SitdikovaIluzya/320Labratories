using System;
using System.Collections.Generic;
using System.Text;

namespace Laboratories320
{
    class ArcherTower : CharacteristicBuilding, IBuilding
    {
        public ArcherTower(int defence)
        {
            _defence = defence;
        }
        public void Collabaration()
        {
            Console.WriteLine("ArcherTower Collabaration");
        }
    }
}