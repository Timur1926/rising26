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

            bool IsContinue = true;
            string[] fullName = new string[0];
            string[] position = new string[0];

            Console.WriteLine("\tМЕНЮ");
            Console.WriteLine($"Добавить досье - кнопка {AddDossierCommand};\nВывести всё досье - кнопака {AllDossierCommand};\n" +
                              $"Удалить досье - кнопка {RemoveDossierCommand};\nПоиск по фамилии - кнопка {SearchLastNameCommand};\nВыход - кнопка {ExitCommand}");

            while (IsContinue)
            {
                Console.WriteLine("\t***");
                Console.Write("Выбери номер действие из меню: ");
                string userInput = Console.ReadLine();

                if (AddDossierCommand == userInput)
                {
                    Console.Write("Введите ФИО: ");
                    fullName = AddDossiers(fullName);
                    Console.Write("Введите должность: ");
                    position = AddDossiers(position);
                }
                else if(AllDossierCommand == userInput)
                {
                    DisplayDossier(fullName, position);
                }
                else if (RemoveDossierCommand == userInput)
                {
                    Console.Write("Номер досье для удоления: ");
                    int number = Convert.ToInt32(Console.ReadLine());
                    fullName = RemoveDossiers(fullName, number);
                    position = RemoveDossiers(position, number);
                }
                else if (SearchLastNameCommand == userInput)
                {
                    int index = Search(fullName);
                    Console.WriteLine(fullName[index] + " - " + position[index]);
                }
                else if (ExitCommand == userInput)
                {
                    IsContinue = false;
                } 
                
            }

            Console.WriteLine("Программа завершена !!!");
        }

        static string[] AddDossiers(string[] array1)
        {
            string[] fullNames = new string[array1.Length + 1];

            for (int i = 0; i < array1.Length; i++)
            {
                fullNames[i] = array1[i];
            }
           
            fullNames[fullNames.Length - 1] = Console.ReadLine();
            array1 = fullNames;
            return array1;
        }

        static void DisplayDossier(string[] array1, string[] array2)
        {
            int rowsNumber = 1;

            for (int i = 0; i < array1.Length; i++)
            {
                Console.WriteLine($"{ i + 1}) {array1[i]} - {array2[i]}");
                rowsNumber++;
            }

        }

        static string[] RemoveDossiers(string[] array, int index)
        {
            string[] tempArray = array;
            array = new string[array.Length - 1];
            index -= 1;
            int numberIteration = 0;

            for (int i = 0; i < array.Length; i++)
            {

                if (index == i)
                {
                    numberIteration++;
                    array[i] = tempArray[numberIteration];
                }
                else if (index > i)
                {
                    array[i] = tempArray[numberIteration];
                    numberIteration++;
                }
                else
                {
                    numberIteration++;
                    array[i] = tempArray[numberIteration];
                }
            }

            return array;
        }

        static int Search(string[] array)
        {
            Console.Write("Введите фамилию для поиска досье: ");
            string lastName = Console.ReadLine();
            string[] dossier;
            int index = 0;
            int dossierNumber = 0;

            for (int i = 0; i < array.Length; i++)
            {
                dossier = array[i].Split();

                if (dossier[dossierNumber] == lastName)
                {
                    index = i;
                    dossierNumber++;
                }
            }

            return index;
        }
    }
}
