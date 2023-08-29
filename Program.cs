using System;

namespace WorkingWithProperties
{
    class Program
    {
        static void Main(string[] args)
        {
            Draw displayInfo = new Draw();
            displayInfo.ShowPlayer(5,2,'$');
            Draw displayInfo2 = new Draw();
            displayInfo2.ShowPlayer(10, 5, '&');
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
        public char _simbol { get { return _simbol; } private set { _simbol = value; } }
        public int _positionX { get { return _positionX; } private set { _positionX = value; } }
        public int _positionY { get { return _positionY; } private set { _positionY = value; } }

        public Player (int positionX,  int positionY, char simbol)
        {
            _positionX = positionX;
            _positionY = positionY;
            _simbol = simbol;
        }
    }
}
