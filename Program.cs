using System;

namespace WorkingWithProperties
{
    class Program
    {
        static void Main(string[] args)
        {
            Draw drawPlayer = new Draw();
            Player player1 = new Player(5,2, '$');
            drawPlayer.ShowPlayer(player1.PositionX, player1.PositionY, player1.Simbol);
            Player player2 = new Player(10, 5, '&');
            drawPlayer.ShowPlayer(player2.PositionX, player2.PositionY, player2.Simbol);
        }
    }

    class Draw
    {
        public void ShowPlayer(int positionX, int positionY, char simbol)
        {
            Console.SetCursorPosition(positionX, positionY);
            Console.WriteLine(simbol);
        }
    }

    class Player 
    {
        public Player (int positionX,  int positionY, char simbol)
        {
            PositionX = positionX;
            PositionY = positionY;
            Simbol = simbol;
        }

        public char Simbol { get; private set; }
        public int PositionX { get; private set; }
        public int PositionY { get; private set; }
    }
}
