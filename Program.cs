using System;
using System.Text.RegularExpressions;

namespace Кадровый_учёт
{
    class Program
    {
        static void Main(string[] args)
        {
            const int AddDossierComand = 1;
            const int AllDossierComand = 2;
            const int RemoveDossierComand = 3;
            const int SearchLastNameComand = 4;
            const int ExitComand = 5;

            bool IsContinuation = true;
            string[] fullNameArrays = new string[0];
            string[] postArrays = new string[0];
            Console.WriteLine("\tМЕНЮ");
            Console.WriteLine($"Добавить досье - кнопка {AddDossierComand};\nВывести всё досье - кнопака {AllDossierComand};\n" +
                              $"Удалить досье - кнопка {RemoveDossierComand};\nПоиск по фамилии - кнопка {SearchLastNameComand};\nВыход - кнопка {ExitComand}");

            while (IsContinuation)
            {
                Console.WriteLine("\t***");
                Console.Write("Выбери номер действие из меню: ");
                int numberMуnu = Convert.ToInt32(Console.ReadLine());

                if (AddDossierComand == numberMуnu)
                {
                    Console.Write("Введите ФИО: ");
                    fullNameArrays = AddDossiers(fullNameArrays);
                    Console.Write("Введите должность: ");
                    postArrays = AddDossiers(postArrays);
                }
                else if(AllDossierComand == numberMуnu)
                {
                    DisplayDossier(fullNameArrays, postArrays);
                }
                else if (RemoveDossierComand == numberMуnu)
                {
                    Console.Write("Номер досье для удоления: ");
                    int number = Convert.ToInt32(Console.ReadLine());
                    fullNameArrays = RemoveDossiers(fullNameArrays, number);
                    postArrays = RemoveDossiers(postArrays, number);
                }
                else if (SearchLastNameComand == numberMуnu)
                {
                    int index = Searche(fullNameArrays);
                    Console.WriteLine(fullNameArrays[index] + " - " + postArrays[index]);
                }
                else if (ExitComand == numberMуnu)
                {
                    IsContinuation = false;
                    Console.WriteLine("Программа завершена !!!");
                } 
            }

        }

        static string[] AddDossiers(string[] array1)
        {
            string[] fullNameArrays = new string[array1.Length + 1];

            for (int i = 0; i < array1.Length; i++)
            {
                fullNameArrays[i] = array1[i];
            }
           
            fullNameArrays[fullNameArrays.Length - 1] = Console.ReadLine();
            array1 = fullNameArrays;
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

        static int Searche(string[] array)
        {
            Console.Write("Введите фамилию для поиска досье: ");
            string lastName = Console.ReadLine();
            string[] dossier;
            int index = 0;
            int j = 0;

            for (int i = 0; i < array.Length; i++)
            {
                dossier = array[i].Split();

                if (dossier[j] == lastName)
                {
                    index = i;
                    j++;
                }
            }

            return index;
        }
    }
}
