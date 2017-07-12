using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RockPaperScissors
{
    class RockPaperScissorApp
    {
        static void Main(string[] args)
        {
            bool run = true;
            Console.WriteLine("Welcome to Rock Paper Scissors!");
            
            
            while (run == true)
            {
                Player1 P1 = new Player1();
                string name = P1.getPlayerName();
                string choice = P1.getPlayerChoice();
                string pick = P1.Roshambo();

                if (choice == "2")
                {
                    Player2rocky P2 = new Player2rocky();
                    P2.getPlayer2();
                }

            }


            
        }
    }
}
