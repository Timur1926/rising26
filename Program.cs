using System;

namespace WorkingWithProperties
{
    class Program
    {
        static void Main(string[] args)
        {
            Draw payer1 = new Draw(5, 2);
            payer1.ShowPlayer();
            Draw player2 = new Draw(10, 5);
            player2.ShowPlayer();

        }
    }

    class Player
    {
        protected int X;
        protected int Y;
    }

    class Draw : Player
    {
        private char player = '$';
        
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
