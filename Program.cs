using System;

namespace WorkingWithProperties
{
    class Program
    {
        static void Main(string[] args)
        {
            Draw drawPlayer = new Draw();
            drawPlayer.ShowPlayer();
        }
    }

    class Draw
    {
        Player player = new Player();

        public void ShowPlayer()
        {
            Console.SetCursorPosition(player.PositionX, player.PositionY);
            Console.WriteLine(player.SimbolPlayer);
        }
    }

    class Player 
    {
        public char SimbolPlayer = '$';
        public int PositionX = 5;
        public int PositionY = 2;

        public Player() { }

        public Player (int positionX,  int positionY, char simbolPlayer)
        {
            PositionX = positionX;
            PositionY = positionY;
            SimbolPlayer = simbolPlayer;
        }
    }
}
