using System;

namespace BraveNewWorld
{
    class Program
    {
        static void Main(string[] args)
        {
            DrawMap();
        }

        static void DrawMap()
        {
            Console.CursorVisible = false;
            
            char[,] map =
            {
                {'#','#','#','#','#','#','#','#','#','#','#','#','#','#','#','#','#'},
                {'#',' ',' ',' ',' ',' ','$',' ',' ',' ',' ',' ',' ',' ',' ',' ','#'},
                {'#','#','#','#','#','#','#','#',' ','#','#','#','#','#','#','#','#'},
                {'#',' ',' ',' ','$',' ',' ',' ',' ',' ','$',' ',' ',' ',' ',' ','#'},
                {'#','#','#','#','#','#','#','#',' ','#','#','#','#','#','#','#','#'},
                {'#',' ',' ',' ',' ',' ','$',' ',' ',' ',' ',' ',' ',' ',' ','$','#'},
                {'#','#','#','#','#','#','#','#',' ','#','#','#','#','#','#','#','#'},
                {'#',' ',' ',' ','$',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ','#'},
                {'#','#','#','#','#','#','#','#',' ','#','#','#','#','#','#','#','#'},
                {'#',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ','$','#'},
                {'#','#','#','#',' ','#','#','#',' ','#',' ','#','#','#','#','#','#'},
                {'#',' ',' ',' ',' ',' ',' ','#',' ',' ',' ',' ',' ',' ',' ',' ','#'},
                {'#','$',' ','#',' ','$',' ','#',' ','$','#',' ',' ','#',' ','$','#'},
                {'#',' ',' ','#',' ',' ',' ',' ',' ',' ','#',' ',' ','#',' ',' ','#'},
                {'#','#','#','#','#','#','#','#','#','#','#','#','#','#','#','#','#'},
            };

            int userX = 1, userY = 1;
            char userDog = '@';
            char blockPlayerPosition = '#';
            char item = '$';
            string backpack = "";

            while (true)
            {

                for (int i = 0; i < map.GetLength(0); i++)
                {

                    for (int j = 0; j < map.GetLength(1); j++)
                    {
                        Console.Write(map[i, j]);
                    }

                    Console.WriteLine();
                }

                Console.WriteLine($"\nСобранных предметов в рюкзаке: ({backpack.Length}) - {backpack}");
                Console.SetCursorPosition(userX, userY);
                Console.Write(userDog);
                ConsoleKeyInfo charKey = Console.ReadKey();

                switch (charKey.Key)
                {

                    case ConsoleKey.RightArrow:

                        if (map[userY, userX + 1] != blockPlayerPosition)
                        {
                            userX++;
                            
                            if (map[userY, userX] == item)
                            {
                                backpack += item;
                                map[userY, userX] = ' ';
                            }

                        }

                        break;

                    case ConsoleKey.LeftArrow:

                        if (map[userY, userX - 1] != blockPlayerPosition)
                        {
                            userX--;

                            if (map[userY, userX] == item)
                            {
                                backpack += item;
                                map[userY, userX] = ' ';
                            }

                        }

                        break;

                    case ConsoleKey.UpArrow:

                        if (map[userY - 1, userX] != blockPlayerPosition)
                        {
                            userY--;

                            if (map[userY, userX] == item)
                            {
                                backpack += item;
                                map[userY, userX] = ' ';
                            }

                        }

                        break;

                    case ConsoleKey.DownArrow:

                        if (map[userY + 1, userX] != blockPlayerPosition)
                        {
                            userY++;

                            if (map[userY, userX] == item)
                            {
                                backpack += item;
                                map[userY, userX] = ' ';
                            }

                        }

                        break;
                }

                Console.Clear();
            }
        }
    }
}
