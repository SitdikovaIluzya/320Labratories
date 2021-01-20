using Laboratories320.Seydametov.StrategyGame;
using System;
using System.Collections.Generic;
using System.Text;

namespace Laboratories320.Seydametov.Game
{
    class StartGame
    {
        public void Start() 
        {
            Attacker attacker1 = new Attacker("vitala", 100);
            Defender def1 = new Defender("gilent", 100);
            Sniper snip1 = new Sniper("s1mple", 120, 100);
        }
    }
}
