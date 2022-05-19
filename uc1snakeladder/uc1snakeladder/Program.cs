// See https://aka.ms/new-console-template for more information
Console.WriteLine("Hello, World!");
uc1snakeladder.uc1snakeladder sc = new uc1snakeladder.uc1snakeladder();
sc.Position();
int dice=sc.diceroll();
sc.checkoption( dice);
sc.dicerollgame( dice);
