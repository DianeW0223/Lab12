using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RockPaperScissors
{
    abstract class Players
    {
        private string name;
        bool run = true;
        private string input, thro;
        

        //this method requests the user to input their name.
        public virtual string setName()
        {
            Console.WriteLine("Please enter your name Player 1");
            name = Console.ReadLine();
            name = name.Trim();
            return name;
        }
        // this method retrieves the name.
        public virtual string getName()
        {
            return name;
        }
        //this method requests/sets which player to play.
        public string setPlayerChoice()
        {
            Console.WriteLine("Hi " + name + "! Would you like to play against Player 2, Player 3, or Player 4? Enter 2 or 3 or 4.");
            input = Console.ReadLine();
            Console.WriteLine("Great " + name + "!");
            return input;
        }
        //this method requests/sets the users choice for Roshambo (Rock, Paper or Scissors)
        public string setRoshambo()
        {
            Console.WriteLine("Please choose Rock, Paper or Scissors");
            thro = Console.ReadLine();
            thro = thro.ToLower();
            return thro;
        }
        //this method retrieves the the users Roshambo choice
        public string getRoshambo()
        {
            return thro;
        }
        //this method runs the application.
        public void runApp()
        {
            
            while (run == true)
            {
                string choice = setPlayerChoice();
                choice = choice.Trim();
                string setPick = setRoshambo();
                string pick=getRoshambo();
                //here is the code for the player two choice.
                if (choice == "2")
                {
                    Player2rocky P2 = new Player2rocky();
                    string P2Picks= P2.getPlayer2();
                    string results = getResults(pick, P2Picks);
                    Console.WriteLine(name + ": " + pick + "\n" + "Player 2: " + P2.getPlayer2());
                    Console.WriteLine(results);
                }
                //here is what happens for the player three choice.
                else if (choice == "3")
                {
                    Player3random P3 = new Player3random();
                    P3.getRandom();
                    string P3Picks=P3.getRPS();
                    string results = getResults(pick, P3Picks);
                    Console.WriteLine(name + ": " + pick + "\n" + "Player 3: " + P3.getRPS());
                    Console.WriteLine(results);
                }
                //here is what happens if you choose player 4
                else if (choice == "4")
                {
                    string results = getResults(pick, pick);
                    Console.WriteLine(name + ": " + pick + "\n" + "Player 4: " + pick);
                    Console.WriteLine(results);
                }
                
                run = Continue();
            }
        }
        //this method returns the results of the game.
        public string getResults(string x, string y)
        {
            if ((x == "rock" & y == "paper") || (x == "paper" & y == "rock"))
            {
                return "Paper covers rock, Paper Wins";
            }
            else if ((x == "rock" & y == "scissors") || (x == "scissors" & y == "rock"))
            {
                return "Rock smashes scissors, Rock Wins";
            }
            else if ((x == y) || (y == x))
            {
                return "Its a Draw, You both Win";

            }
            else if ((x == "scissors" & y == "paper") || (x == "paper" & y == "scissors"))
            {
                return "Scissors cuts paper, Paper Wins!";
            }
            else
            {
                return "I don't know who won";
            }


        }
        //continue method to replay the game
        public static Boolean Continue()
        {
            Boolean run;
            Console.WriteLine("Play Again? Y/N");
            String answer = Console.ReadLine();
            int count = 0;
            

            if ((answer == "Y") || (answer == "y"))
            {
                run = true;
            }
            else if ((answer == "N") || (answer == "n"))
            {
                run = false;
                Console.WriteLine("Good Bye!");
                Console.WriteLine("You played " + count + " game(s)");
                count++;
            }
            else
            {
                Console.WriteLine("I'm sorry I don't understand. Let's try again");
                run = Continue();
            }
            return run;



        }
        
    }
}
