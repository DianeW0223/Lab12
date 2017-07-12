using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RockPaperScissors
{
    class Player2rocky : Players
    {
       
        public string getPlayer2()
        {
            Player1 P1 = new Player1();
            string name = P1.getName();
            string choice = P1.getRoshambo();
            Console.WriteLine("name and choice should be below");
            return name + choice;
            //string playerTwo = "rock";
            //return "\n" + name + choice + ":" + "\nPlayer 2: " + playerTwo;
        }
    }
}
