using System;
using System.Collections.Generic;

namespace PlayerDatabase
{
    class Program
    {
        static void Main(string[] args)
        {

            bool canExit = true;
            Player user = new Player();

            Console.WriteLine("\tМеню");
            Console.WriteLine("кнопка 1: добавить нового игрока");
            Console.WriteLine("кнопка 2: показать всех игроков");
            Console.WriteLine("кнопка 3: наложить запрет на игрока");
            Console.WriteLine("кнопка 4: снять запрет с игрока");
            Console.WriteLine("кнопка 5: удолить игрока");
            Console.WriteLine("кнопка 6: выход из программы");

            while (canExit)
            {
                Console.WriteLine("--------------------------");
                Console.Write("Выбери номер команды:");
                string comandNumber;
                comandNumber = Console.ReadLine();

                switch (comandNumber)
                {

                    case "1":
                        user.UserNew();
                        break;

                    case "2":
                        user.InfoDataPlayers();
                        break;

                    case "3":
                        user.PayerLock();
                        break;

                    case "4":
                        user.PlayerUnLock();
                        break;

                    case "5":
                        user.PlayerDelit();
                        break;

                    case "6":
                        canExit = false;
                        break;

                    default:
                        Console.WriteLine("!!!!! Такой команды в меню нет !!!!!");
                        break;
                }
            }

            Console.Clear();
        }
    }

    class DataBase
    {
        protected Dictionary<int, string> DataPlayers = new Dictionary<int, string>();
    }

    class Player : DataBase
    {
        protected string _nickName = null;
        protected int _iD = 0;
        protected string _level = null;
        protected bool _banPlayer;

        public void UserNew()

        {
            _iD++;
            Console.WriteLine("----------------------");
            Console.WriteLine("Заполни свои данные");
            Console.Write("Введи свой nick name: ");
            _nickName = Console.ReadLine();
            Console.Write("Введи свой уровень: ");
            _level = Console.ReadLine();
            string userNew = $"{_nickName }\t\t{_level}\t\t{_iD}";
            DataPlayers.Add(_iD, userNew);
        }

        public void InfoDataPlayers()
        {
            Console.WriteLine("------------------------------------------");
            Console.WriteLine("Имя игрока | Уровень игрока | ID игрока");
            int id = 1;

            for (int i = 0; i < DataPlayers.Count; )
            {
                
                if (DataPlayers.ContainsKey(id))
                {
                    Console.WriteLine(DataPlayers[id]);
                    id++;
                    i++;
                }
                else
                {
                    id++;
                }
            }
        }

        public void PayerLock()
        {
            Console.Write("ID игрока для блокировки: ");
            int id = Int32.Parse(Console.ReadLine());
            string playerLock = "\t\t!!!Игрок заблокирован!!!";

            for (int i = 0; i < DataPlayers.Count; i++)
            {
                _banPlayer = DataPlayers[id].EndsWith(playerLock);

                if (_banPlayer)
                {
                    Console.WriteLine("!!!! ID уже заблокирован");
                    i = DataPlayers.Count;
                }
                else
                {
                    DataPlayers[id] = DataPlayers[id] + playerLock;
                    i = DataPlayers.Count;
                }
            }
        }

        public void PlayerUnLock()
        {
            Console.Write("ID игрока для разблокировки: ");
            int id = Int32.Parse(Console.ReadLine());
            string playerLock = "\t\t!!!Игрок заблокирован!!!";

            for (int i = 0; i < DataPlayers.Count; i++)
            {
                DataPlayers[id] = DataPlayers[id].TrimEnd(playerLock.ToCharArray());
                i = DataPlayers.Count;
            }
        }

        public void PlayerDelit()
        {
            Console.Write("ID игрока для удоления: ");
            int id = Int32.Parse(Console.ReadLine());

            for (int i = 0; i < DataPlayers.Count; i++)
            {
                DataPlayers.Remove(id);
                i = DataPlayers.Count;
            }
        }
    }
}



