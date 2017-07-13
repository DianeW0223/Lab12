using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RockPaperScissors
{
    class Player2rocky : Players
    {
        //this method always returns rock for player two.
        public Player2rocky()
        {
            getPlayer2();
        }
        
        public string getPlayer2()
        {
            return "rock";
        }
    }
}
