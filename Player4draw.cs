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
        
        public void Draw()
        {
            Player1 P1 = new Player1();
            player4 = P1.getRoshambo();
            string p1Name = P1.getName();
            Console.WriteLine(p1Name + ":" + player4 + "\nPlayer 4:"+player4);
            
        }
    }
}
