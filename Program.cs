using System;


namespace Кадровый_учёт
{
    class Program
    {
        static void Main(string[] args)
        {
            const int AddDossier = 1;
            const int AllDossiers = 2;
            const int RemoveDossiers = 3;
            const int SearchLastName = 4;
            const int Exit = 5;
            Console.WriteLine("\tМЕНЮ");
            Console.WriteLine($"Добавить досье - кнопка {AddDossier};\nВывести всё досье - кнопака {AllDossiers};\n" +
                              $"Удалить досье - кнопка {RemoveDossiers};\nПоиск по фамилии - кнопка {SearchLastName};\nВыход - кнопка {Exit}");
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
                        //Добавить досье
                        AddFioPost(ref fioArray, ref postArray);
                        break;
                    case AllDossiers:
                        //Вывести всё досье
                        DisplayDossier(ref fioArray, ref postArray);
                        break;
                    case RemoveDossiers:
                        //Удалить досье
                        RemoveDossier(ref fioArray, ref postArray);
                        break;
                    case SearchLastName:
                        //Поиск по фамилии
                        //LastNameSearch(ref fioArray, ref postArray);
                        break;
                    case Exit:
                        //Выход
                        continuation = false;
                        Console.WriteLine("Программа завершена !!!");
                        break;
                    default:
                        Console.WriteLine("ERROR!!! Такой пункт меню остутствует!!!");
                        break;
                }
            }

        }

        static void AddFioPost(ref string[] array1, ref string[] array2)
        {
            string[] tempFioArray = new string[array1.Length + 1];
            string[] tempPostArray = new string[array2.Length + 1];

            for (int i = 0; i < array1.Length; i++)
            {
                tempFioArray[i] = array1[i];
                tempPostArray[i] = array2[i];
            }

            Console.Write("Enter last name: "); 
            string lastName = Console.ReadLine();
            Console.Write("Enter first name: ");
            string firstName = Console.ReadLine();
            Console.Write("Enter midle name: ");
            string midleName = Console.ReadLine();
            Console.Write("Enter post: ");
            string post = Console.ReadLine();
            tempFioArray[tempFioArray.Length - 1] = lastName+" "+firstName+" "+ midleName;
            tempPostArray[tempPostArray.Length - 1] = post;
            array1 = tempFioArray;
            array2 = tempPostArray;
            
        }
        
        static void DisplayDossier(ref string[]array1,ref string[]array2)
        {
            Console.WriteLine("\tДосье всех сотрудников");
            int number = 1;

            for(int i = 0; i < array1.Length; i++)
            {
                Console.WriteLine($"{number}) {array1[i]} - {array2[i]}");
                number++;
            }

            Console.WriteLine();
        }
        
        static void RemoveDossier(ref string[]array1, ref string[]array2)
        {
            Console.Write("Введите номер досье которое нужно удалить: ");
            int numberDossierDelet  = Convert.ToInt32(Console.ReadLine());
            numberDossierDelet -= 1;
            int number = 0;
            string[] tempFioArray = new string[array1.Length - 1];
            string[] tempPostArray = new string[array2.Length - 1];

            for (int i = 0; i < tempFioArray.Length; i++)
            {

                if (i == numberDossierDelet) 
                {
                    number++;
                    tempFioArray[i] = array1[number];
                    tempPostArray[i] = array2[number];
                }
                else if (numberDossierDelet == tempFioArray.Length)
                {
                    tempFioArray[i] = array1[number];
                    tempPostArray[i] = array2[number];
                    number++;
                }
                else
                {
                    number++;
                    tempFioArray[i] = array1[number];
                    tempPostArray[i] = array2[number];
                }  

            }

            array1 = tempFioArray;
            array2 = tempPostArray;
        }

        static void LastNameSearch(ref string[]Array1, ref string[]Array2)
        {
            
        }
    }
}
