using System;

namespace WorkingWithProperties
{
    class Program
    {
        static void Main(string[] args)
        {
            Player simbolPlayer = new Player();
            Draw payer1 = new Draw(5,2);
            payer1.ShowPlayer(simbolPlayer.simbolPlayer);
            Draw player2 = new Draw(10, 5);
            player2.ShowPlayer(simbolPlayer.simbolPlayer);
        }
    }

    class Draw
    {
        protected int _positionX;
        protected int _positionY;

        public Draw() { }

        public Draw(int positionX, int positionY)
        {
            _positionX = positionX;
            _positionY = positionY;
        }
        
        public void ShowPlayer(char playerSimbol)
        {
            Console.SetCursorPosition(_positionX, _positionY);
            Console.WriteLine(playerSimbol);
        }
    }

    class Player : Draw
    {
        public char simbolPlayer = '$';

        public Player() { }

        public Player(int positionX, int positionY) : base(positionX, positionY)
        {
            _positionX = positionX;
            _positionY = positionY;
        }
    }
}
