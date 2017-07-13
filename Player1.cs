using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RockPaperScissors
{
    class Player1 : Players
    {
        
        //here we are asking to run the method from the parent to request the name and run the application.        
        public Player1()
        {
            setName();
            runApp();
            
        }      
                
        
        
    }
}
