using System;

namespace BraveNewWorld
{
    class Program
    {
        static void Main(string[] args)
        {
            DrawMap();
            Console.WriteLine("Игра окончена!!!");
        }

        static void DrawMap()
        {
            Console.CursorVisible = false;
            int userX = 1;
            int userY = 1;
            char hero = '@';
            int pocket = 0;
            bool isFinish = true;
            char[,] map =
            {
                {'#','#','#','#','#','#','#','#','#','#','#','#','#','#','#','#','#'},
                {'#',' ',' ','$',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ','#'},
                {'#','#','#','#','#','#','#','#',' ','#','#','#','#','#','#','#','#'},
                {'#',' ',' ',' ','$',' ',' ',' ',' ',' ','$',' ',' ',' ',' ',' ','#'},
                {'#','#','#','#','#','#','#','#','$','#','#','#','#','#','#','#','#'},
                {'#',' ',' ',' ',' ',' ','$',' ',' ',' ',' ',' ',' ',' ',' ','$','#'},
                {'#','#','#','#','#','#','#','#',' ','#','#','#','#','#','#','#','#'},
                {'#',' ',' ',' ','$',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ','#'},
                {'#','#','#','#','#','#','#','#','$','#','#','#','#','#','#','#','#'},
                {'#',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ','$','#'},
                {'#','#','#','#',' ','#','#','#',' ','#',' ','#','#','#','#','#','#'},
                {'#',' ','$','#',' ',' ',' ','#',' ',' ',' ',' ',' ',' ',' ',' ','#'},
                {'#','$',' ','#',' ','$',' ','#',' ','$','#',' ',' ','#',' ','$','#'},
                {'#',' ',' ',' ',' ',' ',' ',' ',' ',' ','#',' ',' ','#',' ',' ','#'},
                {'#','#','#','#','#','#','#','#','#','#','#','#','#','#','#','#','#'},
            };

            while (isFinish)
            {

                for (int i = 0; i < map.GetLength(0); i++)
                {

                    for (int j = 0; j < map.GetLength(1); j++)
                    {
                        Console.Write(map[i, j]);
                    }

                    Console.WriteLine();
                }

                Console.WriteLine($"\n\n\n\nКарман: {pocket}$");
                Console.SetCursorPosition(userY, userX);
                Console.Write(hero);
                MoveHero(map, ref userX, ref userY, ref pocket);
                isFinish = TryExit(pocket);
                Console.Clear();
            }

        }

        static void MoveHero(char[,] map, ref int userX, ref int userY, ref int pocket)
        {
            ConsoleKeyInfo keyInfo = Console.ReadKey();
            const ConsoleKey right = ConsoleKey.RightArrow;
            const ConsoleKey left = ConsoleKey.LeftArrow;
            const ConsoleKey up = ConsoleKey.UpArrow;
            const ConsoleKey down = ConsoleKey.DownArrow;

            switch (keyInfo.Key)
            {
                case right:
                    DataChecking(map, ref userX, ref userY, ref pocket, right);
                    break;

                case left:
                    DataChecking(map, ref userX, ref userY, ref pocket, left);
                    break;

                case up:
                    DataChecking(map, ref userX, ref userY, ref pocket, up);
                    break;

                case down:
                    DataChecking(map, ref userX, ref userY, ref pocket, down);
                    break;
            }
            
        }

        static void DataChecking(char[,] map, ref int userX, ref int userY, ref int pocket, ConsoleKey key)
        {
            const char wall = '#';
            char dollar = '$';
            char collectDollar = ' ';
            const ConsoleKey right = ConsoleKey.RightArrow;
            const ConsoleKey left = ConsoleKey.LeftArrow;
            const ConsoleKey up = ConsoleKey.UpArrow;
            const ConsoleKey down = ConsoleKey.DownArrow;

            if (right == key && map[userX, userY + 1] != wall)
            {

                if (map[userX, userY] == dollar)
                {
                    map[userX, userY] = collectDollar;
                    pocket += dollar;
                    userY++;
                }
                else
                {
                    userY++;
                }

            }
            else if (left == key && map[userX, userY - 1] != wall)
            {

                if (map[userX, userY] == '$')
                {
                    map[userX, userY] = ' ';
                    pocket += dollar;
                    userY--;
                }
                else
                {
                    userY--;
                }

            }
            else if (up == key && map[userX - 1, userY] != wall)
            {

                if (map[userX, userY] == '$')
                {
                    map[userX, userY] = ' ';
                    pocket += dollar;
                    userX--;
                }
                else
                {
                    userX--;
                }

            }
            else if (down == key && map[userX + 1, userY] != wall)
            {

                if (map[userX, userY] == '$')
                {
                    map[userX, userY] = ' ';
                    pocket += dollar;
                    userX++;
                }
                else
                {
                    userX++;
                }

            }

        }

        static bool TryExit(int pocket)
        {
            bool finish = true;
            int money = 504;

            if (pocket == money)
            {
                finish = false;
            }

            return finish;
        }

    }
}
