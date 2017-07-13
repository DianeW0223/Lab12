using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RockPaperScissors
{
    class Player3random : Players
    {
        private int randomThrow;
        private string r;
        Random rdm = new Random();

        public int getRandom()
        {
            randomThrow = rdm.Next(1, 3);
            return randomThrow;
        }
        public string getRPS()
        {
           
            if (randomThrow == 1)
            {
                return r = "rock";
            }
            else if (randomThrow == 2)
            {
                r = "paper";
            }
            else if (randomThrow == 3)
            {
                r = "scissors";
            }
            return r;
        }
    }
}
