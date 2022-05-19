using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace uc1snakeladder
{
    internal class uc1snakeladder
    {
        int position1 = 0, position2 = 0, count = 0;
        public void Position()
        {
            Console.WriteLine("Initial  position of player is " + position2);

        }
        Random random = new Random();
        public void diceroll()
        {
            int diceno = random.Next(1, 6);
            Console.WriteLine("dice value of player is " + diceno);

        }




    }
}
