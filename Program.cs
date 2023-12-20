using System;
using System.Collections.Generic;

namespace PlayerDatabase
{
    class Program
    {
        static void Main(string[] args)
        {
            const string ComandAddNewUser = "1";
            const string ComandListUser = "2";
            const string ComandBanUser = "3";
            const string ComandUnBlockUser = "4";
            const string ComandDeletUser = "5";
            const string ComandProgramExit = "6";
            bool canExit = true;
            Database database = new Database();

            Console.WriteLine("\tМеню");
            Console.WriteLine($"кнопка {ComandAddNewUser}: добавить нового игрока");
            Console.WriteLine($"кнопка {ComandListUser}: показать всех игроков");
            Console.WriteLine($"кнопка {ComandBanUser}: наложить запрет на игрока");
            Console.WriteLine($"кнопка {ComandUnBlockUser}: снять запрет с игрока");
            Console.WriteLine($"кнопка {ComandDeletUser}: удолить игрока");
            Console.WriteLine($"кнопка {ComandProgramExit}: выход из программы");

            while (canExit)
            {
                Console.WriteLine("--------------------------");
                Console.Write("Выбери номер команды: ");
                string comandNumber;
                comandNumber = Console.ReadLine();
                Console.WriteLine("--------------------------");

                switch (comandNumber)
                {

                    case ComandAddNewUser:
                        database.AddUserNew();
                        break;

                    case ComandListUser:
                        database.ShowUsersInfo();
                        break;

                    case ComandBanUser:
                        database.LockUser();
                        break;

                    case ComandUnBlockUser:
                        database.UnLockUser();
                        break;

                    case ComandDeletUser:
                        database.DeletUser();
                        break;

                    case ComandProgramExit:
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

    class Player
    {

        public Player(string nickName, string level, int id, bool canLock)
        {
            NickName = nickName;
            Level = level;
            Id = id;
            IsPlayerBlocked = canLock;
        }

        public bool IsPlayerBlocked { get; private set; }
        public string NickName { get; private set; }
        public string Level { get; private set; }
        public int Id { get; private set; }

        public Player GetTryPlayer(ref Player player)
        {

            if (player.IsPlayerBlocked)
            {
                player.IsPlayerBlocked = false;
                return player;
            }
            else
            {
                player.IsPlayerBlocked = true;
                return player;
            }

        }

    }

    class Database
    {
        private Dictionary<int, Player> _players = new Dictionary<int, Player>();
        private int _key = 1;
        private bool _canLock = true;

        public void AddUserNew()
        {
            Console.Write("Придумай Nickname: ");
            string nickName = Console.ReadLine();
            Console.Write("Твой Level: ");
            string level = Console.ReadLine();
            Player player = new Player(nickName, level, _key, _canLock);
            _players.Add(_key, player);
            _key++;
        }

        public void ShowUsersInfo()
        {
            Console.WriteLine("Nickname\tLevel\t\tId");

            foreach (var player in _players)
            {

                if (player.Value.IsPlayerBlocked)
                {
                    Console.WriteLine($"{player.Value.NickName}\t\t{player.Value.Level}\t\t{player.Value.Id}");
                }
                else
                {
                    Console.WriteLine($"{player.Value.NickName}\t\t{player.Value.Level}\t\t{player.Value.Id}\t\t!!!Игрок заблокирован!!!");
                }

            }

        }

        public void LockUser()
        {
            Console.Write("введи id игрока для блокировки: ");
            string id = Console.ReadLine();

            if (Int32.TryParse(id, out int key))
            {
                Player player = _players[key];
                _players[key] = player.GetTryPlayer(ref player);
            }
            else
            {
                Console.WriteLine("Ввод некорректный!!!");
            }

        }

        public void UnLockUser()
        {
            Console.Write("введи id игрока для разблокировки: ");
            string id = Console.ReadLine();

            if (Int32.TryParse(id, out int key))
            {
                Player player = _players[key];
                _players[key] = player.GetTryPlayer(ref player);
            }
            else
            {
                Console.WriteLine("Ввод некорректный!!!");
            }

        }

        public void DeletUser()
        {
            Console.Write("введи id игрока для удоления: ");
            string id = Console.ReadLine();

            if (Int32.TryParse(id, out int key))
            {

                if (_players.ContainsKey(key))
                {
                    _players.Remove(key);
                }
                else
                {
                    Console.WriteLine("Такого игрока в базе не существует!!!");
                }

            }
            else
            {
                Console.WriteLine("Ввод некорректный!!!");
            }

        }

    }

}