using System;
using System.Collections.Generic;

namespace PlayerDatabase
{
    class Program
    {
        static void Main(string[] args)
        {
            const string addNewUser = "1";
            const string listUser = "2";
            const string banUser = "3";
            const string unBlockUser = "4";
            const string deletUser = "5";
            const string programExit = "6";
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

                    case addNewUser:
                        info.AddDataNew();
                        break;

                    case listUser:
                        info.ShowUsersInfo();
                        break;

                    case banUser:
                        info.LockUser();
                        break;

                    case unBlockUser:
                        info.UnLockUser();
                        break;

                    case deletUser:
                        info.DeletUser();
                        break;

                    case programExit:
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
        Dictionary<int, string> _informations = new Dictionary<int, string>();
        Player _player = new Player();

        public void AddDataNew()
        {
            _informations.Add(_player._id, _player.AddPlayer());
        }

        public void ShowUsersInfo()
        {
            
            int id = 1;
            Console.WriteLine("Nikname\t\tLevel\t\tID");

            for (int i = 0; i < _informations.Count;)
            {

                if (_informations.ContainsKey(id))
                {
                    Console.WriteLine(_informations[id]);
                    id++;
                    i++;
                }
                else
                {
                    id++;
                }
            }
        }

        public void LockUser()
        {
            Console.Write("=> Выбери номер ID для блокировки: ");
            string number = Console.ReadLine();
            Int32.TryParse(number, out int id);
            string userLock = "!!!Игрок заблокирован!!!";

            if (_informations.ContainsKey(id))
            {
                _informations[id] = $"{_informations[id]}\t\t{userLock}";
            }
        }

        public void UnLockUser()
        {
            Console.Write("=> Выбери номер ID для разблокировки: ");
            string identification = Console.ReadLine();
            Int32.TryParse(identification, out int id);
            string userLock = "!!!Игрок заблокирован!!!";

            if (_informations.ContainsKey(id))
            {
                _informations[id] = _informations[id].TrimEnd(userLock.ToCharArray());
            }
        }

        public void DeletUser()
        {
            Console.Write("=> Выбери ID для удоления: ");
            string identification = Console.ReadLine();
            Int32.TryParse(identification, out int id);

            if (_informations.ContainsKey(id))
            {
                _informations.Remove(id);
            }
        }
    }

    class Player
    {
        private string _nickName;
        private string _level;
        internal int _id = 1;

        public string AddPlayer()
        {

            string userInfo;
            Console.WriteLine("\tВвод данных");
            Console.Write("Придумай nickname: ");
            _nickName = Console.ReadLine();
            Console.Write("Твой уровень: ");
            _level = Console.ReadLine();
            userInfo = $"{_nickName}\t\t{_level}\t\t{_id}";
            _id++;
            return userInfo;
        }
    }
}