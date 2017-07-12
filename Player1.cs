using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RockPaperScissors
{
    class Player1 : Players
    {
        private string name;
        private string input;
        private string thro;
       
        

        public override string getPlayerName()
        {
            Console.WriteLine("Please enter your name Player 1");
            name = Console.ReadLine();
            return name;
        }
        public string getPlayerChoice()
        {
            Console.WriteLine("Hi " + name + "! Would you like to play against Player 2 or Player 3? Enter 2 or 3.");
            input = Console.ReadLine();
            Console.WriteLine("Great " + name + "!");
            return input;
        }

        public string Roshambo()
        {
            Console.WriteLine("Please choose Rock, Paper or Scissors");
            thro = Console.ReadLine();
            thro = thro.ToLower();
            return thro;
        }

        public string getInput()
        {
            return input;
        }

        public string getName()
        {
            return name;
        }

        public string getRoshambo()
        {
            return thro;
        }
        
    }
}
