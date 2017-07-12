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
        public int getRandom(int x)
        {
            Random rdm = new Random();
            randomThrow = rdm.Next(1, 3);
            return randomThrow;
        }
        public string getRPS()
        {
           
            if (randomThrow == 1)
            {
                return r = "Rock";
            }
            else if (randomThrow == 2)
            {
                r = "Paper";
            }
            else if (randomThrow == 3)
            {
                r = "Scissors";
            }
            return r;
        }
    }
}
