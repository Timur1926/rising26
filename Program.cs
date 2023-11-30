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
    class Database
    {
        private Dictionary<int, Player> _players = new Dictionary<int, Player>();
        private int _id = 1;
        private bool _canLock = false;
        private bool GetTryPlayer(Player player)
        {

            if (player != null)
            {
                return true;
            }
            else
            {
                return false;
            }
        }
        public void AddUserNew()
        {
            Console.Write("Придумай себе имя: ");
            string name = Console.ReadLine();
            Console.Write("Укажи свой уровень: ");
            string level = Console.ReadLine();
            _players.Add(_id, new Player(name, level, _id, _canLock));
            _id++;
        }
        public void ShowUsersInfo()
        {
            Console.WriteLine($"Nickname\tLevel\t\tId");

            foreach (var player in _players)
            {

                if (player.Value.IsPlayerBlocked)
                {
                    Console.WriteLine($"{player.Value.NickName}\t\t{player.Value.Level}\t\t{player.Value.Id}\t!!! игрок заблокирован !!!");
                }
                else
                {
                    Console.WriteLine($"{player.Value.NickName}\t\t{player.Value.Level}\t\t{player.Value.Id}");
                }

            }

        }
        public void LockUser()
        {
            Console.Write("Заблокировать игрока с номером id: ");
            string result = Console.ReadLine();
            Int32.TryParse(result, out int key);

            if (_players.ContainsKey(key))
            {
                _players[key].IsPlayerBlocked = true;
            }
            else
            {
                Console.WriteLine("!!! некоретный ввод !!! нкжен id");
            }

        }
        public void UnLockUser()
        {
            Console.Write("Разблокировать игрока с номером id: ");
            string result = Console.ReadLine();

            if (Int32.TryParse(result, out int key))
            {

                if (_players.ContainsKey(key))
                {
                    _players[key].IsPlayerBlocked = false;
                }
                else
                {
                    Console.WriteLine("!!! некоретный ввод !!! нужен id");
                }

            }

        }
        public void DeletUser()
        {
            Console.Write("Удолить игрока с номером id: ");
            string result = Console.ReadLine();

            if (Int32.TryParse(result, out int key))
            {

                if (_players.ContainsKey(key))
                {
                    _players.Remove(key);
                }
                else
                {
                    Console.WriteLine("!!!ERROR!!! Такого игрока в базе нет!!!");
                }

            }

        }

    }
    class Player
    {
        public bool IsPlayerBlocked;
        public Player(string nickName, string level, int id, bool canLock)
        {
            NickName = nickName;
            Level = level;
            Id = id;
            IsPlayerBlocked = canLock;

        }
        public string NickName { get; private set; }
        public string Level { get; private set; }
        public int Id { get; private set; }
    }
}