using System;
using System.Text.RegularExpressions;

namespace Кадровый_учёт
{
    class Program
    {
        static void Main(string[] args)
        {
            const int AddDossier = 1;
            const int AllDossier = 2;
            const int RemoveDossier = 3;
            const int SearchLastName = 4;
            const int Exit = 5;
            Console.WriteLine("\tМЕНЮ");
            Console.WriteLine($"Добавить досье - кнопка {AddDossier};\nВывести всё досье - кнопака {AllDossier};\n" +
                              $"Удалить досье - кнопка {RemoveDossier};\nПоиск по фамилии - кнопка {SearchLastName};\nВыход - кнопка {Exit}");
            bool continuation = true;
            string[] fioArray = new string[0];
            string[] postArray = new string[0];

            while (continuation)
            {
                Console.WriteLine("\t***");
                Console.Write("Выбери номер действие из меню: ");
                int numberMуnu = Convert.ToInt32(Console.ReadLine());

                switch (numberMуnu)
                {
                    case AddDossier:
                        Console.Write("Введите ФИО: ");
                        fioArray = AddDossiers(fioArray);
                        Console.Write("Введите должность: ");
                        postArray = AddDossiers(postArray);
                        break;
                    case AllDossier:
                        DisplayDossier(fioArray, postArray);
                        break;
                    case RemoveDossier:
                        Console.Write("Номер досье для удоления: ");
                        int number = Convert.ToInt32(Console.ReadLine());
                        fioArray = RemoveDossiers(fioArray, number);
                        postArray = RemoveDossiers(postArray, number);
                        break;
                    case SearchLastName:
                        int index = Searche(fioArray);
                        Console.WriteLine(fioArray[index] + " - " + postArray[index]);
                        break;
                    case Exit:
                        continuation = false;
                        Console.WriteLine("Программа завершена !!!");
                        break;
                    default :
                        Console.WriteLine("ERROR!!! Такого пункта в меню нет !!! Попробуй ещё !!!");
                        break;
                }
            }

        }

        static string[] AddDossiers(string[] array)
        {
            string[] tempArray = new string[array.Length + 1];

            for (int i = 0; i < array.Length; i++)
            {
                tempArray[i] = array[i];
            }

            tempArray[tempArray.Length - 1] = Console.ReadLine();
            array = tempArray;
            return array;
        }

        static void DisplayDossier(string[] array1, string[] array2)
        {
            int rowsNumber = 1;

            for (int i = 0; i < array1.Length; i++)
            {
                Console.WriteLine(rowsNumber + ") " + array1[i] + " - " + array2[i]);
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

                if (index == array.Length)
                {
                    array[numberIteration] = tempArray[i];
                    numberIteration++;
                }
                else if (index == i)
                {
                    array[numberIteration] = tempArray[i + 1];
                    numberIteration++;
                }
                else
                {
                    array[numberIteration] = tempArray[i];
                    numberIteration++;
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
                }
            }

            return index;
        }
    }
}
