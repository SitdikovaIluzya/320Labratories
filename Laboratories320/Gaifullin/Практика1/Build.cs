using System;
using System.Collections.Generic;
using System.Text;

namespace Laboratories320.Gaifullin
{
    abstract class Build : Units
    {
        public int Level { get; set; } //уровень    

        public Build(string Name, int Health, int Level) : base(Name, Health)
        {
            this.Level = Level;
            
        }
    }
}
