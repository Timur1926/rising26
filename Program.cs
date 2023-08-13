using System;
using System.Collections.Generic;

namespace КадровыйУчётПродвинутый
{
    class Program
    {
        static void Main(string[] args)
        {
            List<string> fullNameOfEmployees = new List<string>();
            List<string> employeesPosition = new List<string>();

            Console.WriteLine("\tКадровый учёт\n");
            Console.WriteLine("Меню: \tкоманда 1 - добавить досье\n\tкоманда 2 - вывести всё досье\n\tкоманда 3 - удолить досье\n\tкоманда 4 - звершить программу");

            string numberComand;
            bool haveContinue = true;
            const string numberComand1 = "1";
            const string numberComand2 = "2";
            const string numberComand3 = "3";
            const string numberComand4 = "4";

            while (haveContinue)
            {
                Console.Write("\nВыбери номер команды: ");
                numberComand = Console.ReadLine();

                if (numberComand == numberComand1 || numberComand == numberComand2 || numberComand == numberComand3 || numberComand == numberComand4)
                {

                    switch (numberComand)
                    {
                        case numberComand1:
                            AddDossier(ref fullNameOfEmployees, ref employeesPosition);
                            break;
                        case numberComand2:
                            ShowAllDossiers(ref fullNameOfEmployees, ref employeesPosition);
                            break;
                        case numberComand3:
                            DeleteDossier(ref fullNameOfEmployees, ref employeesPosition);
                            break;
                        case numberComand4:
                            Exit(ref haveContinue);
                            break;
                    }
                }
                else
                {
                    Console.WriteLine("ERROR!!! Такой команды в меню нет!!!");
                }
            }
        }

        static void AddDossier(ref List<string> dossier, ref List<string> employe)
        {
            Console.Write("Введите ФИО: ");
            string fullName = Console.ReadLine();
            dossier.Add(fullName);
            Console.Write("Введите должность: ");
            string employePosition = Console.ReadLine();
            employe.Add(employePosition);
        }

        static void ShowAllDossiers(ref List<string> dossiers, ref List<string> empoyes)
        {
            Console.WriteLine("\t\nДосье всех сотрудников");

            for (int i = 0; i < dossiers.Count; i++)
            {
                Console.WriteLine(dossiers[i]+" - "+empoyes[i]);
            }
        }

        static void DeleteDossier(ref List<string> delDossier, ref List<string> delEmploye)
        {
            bool isDeleteItem;
            Console.Write("Введите фамилию того чъё досье нужно удалить: ");
            string farstName = Console.ReadLine();

            for (int i = 0; i < delDossier.Count; i++)
            {
                isDeleteItem = delDossier[i].Contains(farstName.ToLower());

                if (isDeleteItem)
                {
                    delDossier.RemoveAt(i);
                    delEmploye.RemoveAt(i);
                    isDeleteItem = false;
                }
            }
        }

        static bool Exit(ref bool exit)
        {
            exit = false;
            return exit;
        }
    }
}
