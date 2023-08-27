using System;

namespace WorkingWithProperties
{
    class Program
    {
        static void Main(string[] args)
        {
            Draw player1 = new Draw();
            Draw player2 = new Draw();
            player1.X = 5;
            player1.Y = 2;
            player1.ShowPlayer();
            player2.X = 10;
            player2.Y = 5;
            player2.ShowPlayer();

        }
    }

    class Player
    {
        public int X;
        public int Y;

        public Player() { } 
    }

    class Draw : Player
    {
        private char player = '$';

        public Draw() { }

        public Draw(int positionX, int positionY) : base() 
        {
            X = positionX;
            Y = positionY;
        }

        public void ShowPlayer()
        {
            Console.SetCursorPosition(X, Y);
            Console.WriteLine(player);
        }
    }
}
