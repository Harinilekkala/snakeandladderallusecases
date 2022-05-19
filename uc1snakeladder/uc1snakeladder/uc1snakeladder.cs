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
        public void checkoption()
            
            
        {
            int diceNo = random.Next(1, 6);
            switch (random.Next(0, 3))
            {
                case 0:
                    position2 += 0;
                    Console.WriteLine("Player got noPlay Option");
                    break;
                case 1:
                    position2 -= diceNo;
                    break;
                case 2:
                    position2 += diceNo;
                    break;
                default:
                    break;
            }
            Console.WriteLine("dice value of player is{0} with position at {1} ", diceNo, position2);

        }




    }
}
