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
                    fullName = RemoveInformation(fullName, number);
                    position = RemoveInformation(position, number);
                }
                else if (SearchLastNameCommand == userInput)
                {
                    int index = Search(fullName);
                    Console.WriteLine(fullName[index] + " - " + position[index]);
                }
                else if (ExitCommand == userInput)
                {
                    isContinue = false;
                } 
                
            }

            Console.WriteLine("Программа завершена !!!");
        }

        static string[] AddDossiers(string[] tempArray)
        {
            string[] data = new string[tempArray.Length + 1];

            for (int i = 0; i < tempArray.Length; i++)
            {
                data[i] = tempArray[i];
            }
           
            data[data.Length - 1] = Console.ReadLine();
            tempArray = data;
            return tempArray;
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
            index -= 1;
            int numberIteration = 0;
          
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

                if (lastName == dossier[dossierNumber])
                {
                    index = i;
                    dossierNumber++;
                }
            }

            return index;
        }
    }
}
