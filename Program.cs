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
            int userX = 1, userY = 1;
            char hero = '@';
            int pocket = 0;
            bool finish = true;
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

            while (finish)
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
                finish = MoveHero(ref map, ref userX, ref userY, ref pocket);
                Console.Clear();
            }

        }

        static bool MoveHero(ref char[,] map, ref int userX, ref int userY, ref int pocket)
        {
            ConsoleKeyInfo keyInfo = Console.ReadKey();
            char dollar = '$';
            char collectDollar = ' ';
            bool finish = true;
            int money = 504;

            switch (keyInfo.Key)
            {
                case ConsoleKey.RightArrow:
                    break;

                case ConsoleKey.LeftArrow:
                    break;

                case ConsoleKey.UpArrow:
                    break;

                case ConsoleKey.DownArrow:
                    break;
            }

            if (keyInfo.Key == ConsoleKey.RightArrow && map[userX, userY + 1] != '#')
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
            else if (keyInfo.Key == ConsoleKey.LeftArrow && map[userX, userY - 1] != '#')
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
            else if (keyInfo.Key == ConsoleKey.UpArrow && map[userX - 1, userY] != '#')
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
            else if (keyInfo.Key == ConsoleKey.DownArrow && map[userX + 1, userY] != '#')
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

            if (pocket == money)
            {
                finish = false;
            }

            return finish;
        }

    }
}
