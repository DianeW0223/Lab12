using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RockPaperScissors
{
    class Player4draw : Players
    {
        private string player4;
        //this method always returns a draw for player 4
        public void Draw()
        {
            Player1 P1 = new Player1();
            player4 = P1.getRoshambo();
            Console.WriteLine(getName() + ":" + player4 + "\nPlayer 4:"+player4);
            
        }
    }
}
