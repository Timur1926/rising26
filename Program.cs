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
            DataBase info = new DataBase();

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
                        info.UserNew();
                        break;

                    case listUser:
                        info.ShouUserInfo();
                        break;

                    case banUser:
                        info.UserLock();
                        break;

                    case unBlockUser:
                        info.UserUnLock();
                        break;

                    case deletUser:
                        info.UserDelet();
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

    class DataBase
    {
        public Dictionary<int, string> informations = new Dictionary<int, string>();
        Player userNew = new Player();

        public void UserNew()
        {
            informations.Add(userNew.Id, userNew.UserNew());
        }

        public void ShouUserInfo()
        {
            int id = 1;
            Console.WriteLine("Nikname\t\tLevel\t\tID");

            for (int i = 0; i < informations.Count;)
            {

                if (informations.ContainsKey(id))
                {
                    Console.WriteLine(informations[id]);
                    id++;
                    i++;
                }
                else
                {
                    id++;
                }
            }
        }

        public void UserLock()
        {
            Console.Write("=> Выбери номер ID для блокировки: ");
            string identification = Console.ReadLine();
            Int32.TryParse(identification, out int id);

            if (informations.ContainsKey(id))
            {
                informations[id] += $"\t\t!!! заблокирован !!!";
            }
        }

        public void UserUnLock()
        {
            Console.Write("=> Выбери номер ID для разблокировки: ");
            string identification = Console.ReadLine();
            Int32.TryParse(identification, out int id);
            string playerLock = "\t\t!!! заблокирован !!!";

            if (informations.ContainsKey(id))
            {
                informations[id] = informations[id].TrimEnd(playerLock.ToCharArray());
            }
        }

        public void UserDelet()
        {
            Console.Write("=> Выбери ID для удоления: ");
            string identification = Console.ReadLine();
            Int32.TryParse(identification, out int id);

            if (informations.ContainsKey(id))
            {
                informations.Remove(id);
            }
        }
    }

    class Player
    {
        private string _nickName;
        private string _level;
        public int Id = 1;

        public string UserNew()
        {
            string userInfo;
            Console.WriteLine("\tВвод данных");
            Console.Write("Придумай nickname: ");
            _nickName = Console.ReadLine();
            Console.Write("Твой уровень: ");
            _level = Console.ReadLine();
            userInfo = $"{_nickName}\t\t{_level}\t\t{Id}";
            Id++;
            return userInfo;
        }
    }
}



