using System;
using System.Collections.Generic;
using System.Text;

namespace Laboratories320
{
    class Building
    {
        public int CapacityPeople { get; set; }
        public int CapacityObject { get; set; }

        public Building(int capacityPeople, int capacityObject)
        {
            this.CapacityPeople = capacityPeople;
            this.CapacityObject = capacityObject;
        }
    }
}
