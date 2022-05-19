using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace uc1snakeladder
{
    internal class uc1snakeladder
    {
        int position1 = 0, position2 = 0, count = 0, var=0;
        public void Position()
        {
            Console.WriteLine("Initial  position of player is " + position2);

        }
        Random random = new Random();
        public int diceroll()
        {
            int diceno = random.Next(1, 6);
            Console.WriteLine("dice value of player is " + diceno);
            return diceno;
        }
        public  void checkoption(int dice)
            
            
        {
            
            switch (random.Next(0, 3))
            {
                case 0:
                    position2 += 0;
                    Console.WriteLine("Player got noPlay Option");
                    break;
                case 1:
                    position2 -= dice;
                    break;
                case 2:
                    position2 += dice;
                    break;
                default:
                    break;
            }
            Console.WriteLine("dice value of player is{0} with position at {1} ", dice, position2);

        }
         
        
        public void dicerollgame(int dice)
        {
            while (position2 < 100)
            {
                switch (random.Next(0, 3))
                {
                    case 0:
                        position2 += 0;
                        Console.WriteLine("Player got noPlay Option");
                        break;
                    case 1:
                        position2 -= dice;
                        break;
                    case 2:
                        position2 += dice;
                        break;
                    default:
                        break;
                }
                if (position2 < 0)
                {
                    position2 = 0;
                }
                if (position2 > 100)
                {
                    position2 -= dice;
                    while (position2 < 100)
                    {
                        if (dice == (100 - position2))
                        {
                            position2 = 100;
                            Console.WriteLine("Player Won the Game");
                        }
                        else
                        {
                            continue;
                        }
                    }
                }
                Console.WriteLine("Player present Position is at {0}\n", position2);


            }
            Console.WriteLine("Player rolls the dice {0} time to reach Position {1}\n", var, position2);
        }
    }
}



    

