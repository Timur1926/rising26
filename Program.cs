using System;
using System.Text.RegularExpressions;

namespace Кадровый_учёт
{
    class Program
    {
        static void Main(string[] args)
        {
            string AddDossierCommand = "1";
            string AllDossierCommand = "2";
            string RemoveDossierCommand = "3";
            string SearchLastNameCommand = "4";
            string ExitCommand = "5";

            string[] fullName = { };
            string[] position = { };
            bool isContinue = true;
            int numberDossier;

            Console.WriteLine("\tМЕНЮ");
            Console.WriteLine($"Добавить досье - кнопка {AddDossierCommand};\nВывести всё досье - кнопака {AllDossierCommand};\n" +
                              $"Удалить досье - кнопка {RemoveDossierCommand};\nПоиск по фамилии - кнопка {SearchLastNameCommand};\nВыход - кнопка {ExitCommand}");

            while (isContinue)
            {
                Console.WriteLine("\t***");
                Console.Write("Выбери номер действие из меню: ");
                string userInput = Console.ReadLine();

                if (AddDossierCommand == userInput)
                {
                    fullName = AddFullNmae(fullName);
                    position = AddPosition(position);
                }
                else if (AllDossierCommand == userInput)
                {
                    DisplayDossier(fullName, position);
                }
                else if (RemoveDossierCommand == userInput)
                {
                    numberDossier = DeleteDossierWithNumber();
                    fullName = RemoveInformation(fullName, numberDossier);
                    position = RemoveInformation(position, numberDossier);
                }
                else if (SearchLastNameCommand == userInput)
                {
                    SearchLastName(fullName, position);
                }
                else if (ExitCommand == userInput)
                {
                    isContinue = false;
                }

            }

            Console.WriteLine("Программа завершена !!!");
        }
        static string[] AddDossiersInformation(string[] data)
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
        static string[] AddFullNmae(string[] information)
        {
            Console.Write("Введите ваши данные ФИО: ");
            information = AddDossiersInformation(information);
            return information;
        }
        static string[] AddPosition(string[] information)
        {
            Console.Write("Введите вашу должность: ");
            information = AddDossiersInformation(information);
            return information;
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
        static string[] RemoveInformation(string[] data, int index)
        {
            int zero = 0;

            if (data.Length > zero && index <= data.Length)
            {
                string[] tempArray = data;
                data = new string[data.Length - 1];
                int numberIteration = 0;
                index -= 1;

                for (int i = 0; i < data.Length; i++)
                {

                    if (index > i)
                    {
                        data[i] = tempArray[numberIteration];
                        numberIteration++;
                    }
                    else
                    {
                        numberIteration++;
                        data[i] = tempArray[numberIteration];
                    }

                }

            }

            return data;
        }
        static int DeleteDossierWithNumber()
        {
            Console.Write("Введиете номер досье которое нужно удолить: ");
            int numberDossier = Convert.ToInt32(Console.ReadLine());
            return numberDossier;
        }
        static void SearchLastName(string[] fullName, string[] position)
        {
            Console.Write("Введите фамилию для поиска досье: ");
            string lastName = Console.ReadLine();
            string[] name;
            int iteration = 0;

            for (int i = 0; i < fullName.Length; i++)
            {
                char space = ' ';
                name = fullName[i].Split(space);

                if (lastName == name[iteration])
                {
                    Console.WriteLine(fullName[i] + " - " + position[i]);
                }

            }

        }
    }
}
