using System;
using System.Text.RegularExpressions;

namespace Кадровый_учёт
{
    class Program
    {
        static void Main(string[] args)
        {
            const string AddDossierCommand = "1";
            const string AllDossierCommand = "2";
            const string RemoveDossierCommand = "3";
            const string SearchLastNameCommand = "4";
            const string ExitCommand = "5";

            string[] fullName = { };
            string[] position = { };
            bool isContinue = true;

            Console.WriteLine("\tМЕНЮ");
            Console.WriteLine($"Добавить досье - кнопка {AddDossierCommand};\nВывести всё досье - кнопака {AllDossierCommand};\n" +
                              $"Удалить досье - кнопка {RemoveDossierCommand};\nПоиск по фамилии - кнопка {SearchLastNameCommand};\nВыход - кнопка {ExitCommand}");

            while (isContinue)
            {
                Console.WriteLine("\t***");
                Console.Write("Выбери номер действие из меню: ");
                string userInput = Console.ReadLine();

                switch (userInput)
                {
                    case AddDossierCommand:
                        AddInformation(ref fullName, ref position);
                        break;

                    case AllDossierCommand:
                        DisplayDossier(fullName, position);
                        break;

                    case RemoveDossierCommand:
                        RemoveInformation(ref fullName, ref position);
                        break;

                    case SearchLastNameCommand:
                        SearchLastName(ref fullName, ref position);
                        break;

                    case ExitCommand:
                        isContinue = false;
                        break;
                }
                
            }

            Console.WriteLine("Программа завершена !!!");
        }

        static string[] AddDossiers(string[] data)
        {
            string[] tempData = new string[data.Length + 1];

            for (int i = 0; i < data.Length; i++)
            {
                tempData[i] = data[i];
            }

            tempData[tempData.Length - 1] = Console.ReadLine();
            data = tempData;
            return data;
        }

        static void AddInformation(ref string[] fullName, ref string[] position)
        {
            Console.Write("Введите ФИО: ");
            fullName = AddDossiers(fullName);
            Console.Write("Введите должность: ");
            position = AddDossiers(position);
        }

        static void DisplayDossier(string[] fullName, string[] position)
        {
            int rowsNumber = 1;

            for (int i = 0; i < fullName.Length; i++)
            {
                Console.WriteLine($"{ rowsNumber}) {fullName[i]} - {position[i]}");
                rowsNumber++;
            }

        }

        static void RemoveInformation(ref string[] fullName, ref string[] position)
        {
            int verificationСonditions = 0;
            Console.Write("Выберите номер досье для удоления: ");
            int index = Convert.ToInt32(Console.ReadLine());

            if (fullName.Length > verificationСonditions && index <= fullName.Length)
            {
                string[] tempFullName = fullName;
                fullName = new string [fullName.Length - 1];
                string[] tempPosition = position;
                position = new string [position.Length - 1];

                int numberIteration = 0;
                index -= 1;

                for (int i = 0; i < fullName.Length; i++)
                {

                    if (index > i)
                    {
                        fullName[i] = tempFullName[numberIteration];
                        position[i] = tempPosition[numberIteration];
                        numberIteration++;
                    }
                    else
                    {
                        numberIteration++;
                        fullName[i] = tempFullName[numberIteration];
                        position[i] = tempPosition[numberIteration];
                    }

                }

            }
        }

        static void SearchLastName(ref string[] fullName, ref string[] position)
        {
            Console.Write("Введите фамилию для поиска досье: ");
            string lastName = Console.ReadLine();
            string[] name;
            int iterationToSearch = 0;

            for (int i = 0; i < fullName.Length; i++)
            {
                char space = ' ';
                name = fullName[i].Split(space);

                if (lastName == name[iterationToSearch])
                {
                    Console.WriteLine(fullName[i] + " - " + position[i]);
                }

            }

        }
    }
}
