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

            bool isContinue = true;
            string[] fullName = new string[0];
            string[] position = new string[0];
            string name = "fullName";
            string positionName = "positionName";
            int removeDossier = 0;

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
                    fullName = AddDossiers(fullName, name);
                    position = AddDossiers(position, positionName);
                }
                else if (AllDossierCommand == userInput)
                {
                    DisplayDossier(fullName, position);
                }
                else if (RemoveDossierCommand == userInput)
                {
                    removeDossier = DeleteDossierWithNumber();
                    fullName = RemoveInformation(fullName, removeDossier);
                    position = RemoveInformation(position, removeDossier);
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

        static string[] AddDossiers(string[] data, string dataDossier)
        {
            string[] tempData = new string[data.Length + 1];

            for (int i = 0; i < data.Length; i++)
            {
                tempData[i] = data[i];
            }

            if (dataDossier == "fullName")
            {
                Console.Write("Введите ФИО: ");
                tempData[tempData.Length - 1] = Console.ReadLine();
                data = tempData;
            }
            else
            {
                Console.Write("Введите вашу должность: ");
                tempData[tempData.Length - 1] = Console.ReadLine();
                data = tempData;
            }

            return data;
        }

        static void DisplayDossier(string[] fullName, string[] function)
        {
            int rowsNumber = 1;

            for (int i = 0; i < fullName.Length; i++)
            {
                Console.WriteLine($"{ rowsNumber}) {fullName[i]} - {function[i]}");
                rowsNumber++;
            }

        }

        static string[] RemoveInformation(string[] data, int index)
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

            return data;
        }

        static int DeleteDossierWithNumber()
        {
            Console.Write("Введите номер дрсье для удоления: ");
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
                name = fullName[i].Split(' ');

                if (lastName == name[iteration])
                {
                    Console.WriteLine(fullName[i] + " - " + position[i]);
                }
            }

        }
    }
}
