using System;


namespace Кадровый_учёт
{
    class Program
    {
        static string[] AddFio(string[]array)
        {
            string[] tempArrayFIO = new string[array.Length + 1];
            Console.Write("Введите ФИО: ");

            for (int i = 0; i < array.Length; i++)
            {
                tempArrayFIO[i] = array[i];
            }

            tempArrayFIO[tempArrayFIO.Length - 1] = Console.ReadLine();
            array = tempArrayFIO;
            return array;
        }

        static string[] AddPost(string[]array)
        {
            string[] tempArrayPost = new string[array.Length + 1];
            Console.Write("Должность: ");
            string post = Console.ReadLine();

            for (int i = 0; i < array.Length; i++)
            {
                tempArrayPost[i] = array[i];
            }

            tempArrayPost[tempArrayPost.Length - 1] = post;
            array = tempArrayPost;
            return array;
        }

        static void DisplayDossier(string[]array1, string[]array2)
        {
            Console.WriteLine("\tДосье всех сотрудников");
            int numberDossier = 1;

            for (int i = 0; i < array1.Length; i++)
            {
                Console.WriteLine(numberDossier + " " + array2[i] +" - "+ array1[i]);
                numberDossier++;
            }

        }

        static string[] RemoveFio(string[]array, int number)
        {
            string[] tempFio = new string[array.Length - 1];
            array[number] = array[array.Length - 1];

            for (int i = 0; i < tempFio.Length; i++)
            {
                tempFio[i] = array[i]; 
            }

            array = tempFio;
            return array;
        }

        static string[] RemovePost(string[]array, int number)
        {
            string[] tempPost = new string [array.Length - 1];
            array[number] = array[array.Length - 1];

            for (int i = 0; i < tempPost.Length; i++)
            {
                tempPost[i] = array[i];
            }

            array = tempPost;
            return array;
        }
        
        static string SearchLastName(string[]dossier, string[]post)
        {
            Console.Write("Введите фамилию для поиска досье: ");
            string nameLast = Console.ReadLine();
            string dosierNameLast = null;

            for (int i = 0; i < dossier.Length; i++)
            {

                if (dossier[i] == nameLast)
                {
                    dosierNameLast = dossier[i] + " - " + post[i] ;
                }
            }

            return dosierNameLast;
        }

        static void Main(string[] args)
        {
            Console.WriteLine("\tМЕНЮ");
            Console.WriteLine("Добавить досье - кнопка 1;\nВывести всё досье - кнопака 2;\n" +
                              "Удалить досье - кнопка 3;\nПоиск по фамилии - кнопка 4;\nВыход - кнопка 5");
            bool continuation = true;
            string[] arrayFio = new string[0];
            string[] arrayPost = new string[0];
           
            while (continuation)
            {
                Console.WriteLine("\t***");
                Console.Write("Выбери номер действие из меню: ");

                try
                {
                    int numberMуnu = Convert.ToInt32(Console.ReadLine());

                    switch (numberMуnu)
                    {
                        case 1:
                            //Добавить досье
                            arrayFio = AddFio(arrayFio);
                            arrayPost = AddPost(arrayPost);
                            break;
                        case 2:
                            //Вывести всё досье
                            DisplayDossier(arrayFio, arrayPost);
                            break;
                        case 3:
                            //Удалить досье
                            Console.Write("Номер досье для удоления: ");
                            int numberDosinerDelete = Convert.ToInt32(Console.ReadLine());
                            numberDosinerDelete -= 1;
                            arrayPost = RemovePost(arrayPost, numberDosinerDelete);
                            arrayFio = RemoveFio(arrayFio, numberDosinerDelete);
                            break;
                        case 4:
                            //Поиск по фамилии
                            Console.WriteLine(SearchLastName(arrayFio, arrayPost));
                            break;
                        case 5:
                            //Выход
                            continuation = false;
                            Console.WriteLine("Программа завершена !!!");
                            break;
                        default:
                            Console.WriteLine("ERROR!!! Такой пункт меню остутствует!!!");
                            break;
                    }

                }
                catch 
                {
                    Console.WriteLine($"ERROR!!! Неправилтный формат ввода!!!");
                }

            }
        }
    }
}
