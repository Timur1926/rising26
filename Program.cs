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
            Database info = new Database();

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
                Console.Write("Выбери номер команды: ");
                string comandNumber;
                comandNumber = Console.ReadLine();
                Console.WriteLine("--------------------------");

                switch (comandNumber)
                {

                    case ComandAddNewUser:
                        info.AddUserNew();
                        break;

                    case ComandListUser:
                        info.ShowUsersInfo();
                        break;

                    case ComandBanUser:
                        info.LockUser();
                        break;

                    case ComandUnBlockUser:
                        info.UnLockUser();
                        break;

                    case ComandDeletUser:
                        info.DeletUser();
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

            foreach (var item in _players)
            {

                if (item.Value.IsPlayerBlocked)
                {
                    Console.WriteLine($"{item.Value.NickName}\t\t{item.Value.Level}\t\t{item.Value.Id}\t!!! игрок заблокирован !!!");
                }
                else
                {
                    Console.WriteLine($"{item.Value.NickName}\t\t{item.Value.Level}\t\t{item.Value.Id}");
                }
            }
        }

        public void LockUser()
        {
            Console.Write("Заблокировать игрока с номером id: ");
            string result = Console.ReadLine();

            if (Int32.TryParse(result, out int key))
            {

                if (_players.ContainsKey(key))
                {
                    _players[key].IsPlayerBlocked = true;
                }
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
            int key = Int32.Parse(Console.ReadLine());

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

    class Player
    {
        public string NickName { get; private set; }
        public string Level { get; private set; }
        public int Id { get; private set; }
        public bool IsPlayerBlocked { get; set; }

        public Player(string nickName, string level, int id, bool canLock)
        {
            NickName = nickName;
            Level = level;
            Id = id;
            IsPlayerBlocked = canLock;
        }
    }
}