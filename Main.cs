using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LabW2
{
        class Program
        {
            static void Main(string[] args)
            {
                Console.OutputEncoding = Encoding.UTF8;
                Console.InputEncoding = Encoding.UTF8;

                while (true)
                {
                    Console.Clear();
                    Console.WriteLine("=== МЕНЮ ВЫБОРА ЗАДАЧ ===");
                    Console.WriteLine("1 - Имена");
                    Console.WriteLine("2 - Человек");
                    Console.WriteLine("3 - Человек с именем");
                    Console.WriteLine("4 - Города");
                    Console.WriteLine("5 - Создаем Города");
                    Console.WriteLine("6 - Выход");
                    Console.Write("Выберите задачу: ");

                    string choice = Console.ReadLine();

                    switch (choice)
                    {
                        case "1":
                            ShowNameTask();
                            break;
                        case "2":
                            ShowPersonTask();
                            break;
                        case "3":
                            ShowPersonWithNameTask();
                            break;
                        case "4":
                            ShowCityTask();
                            break;
                        case "5":
                            ShowCreateCityTask();
                            break;
                        case "6":
                            Console.WriteLine("Выход из программы...");
                            return;
                        default:
                            Console.WriteLine("Неверный выбор! Нажмите любую клавишу для продолжения...");
                            Console.ReadKey();
                            break;
                    }
                }
            }

            static void ShowNameTask()
            {
                Console.Clear();
                Console.WriteLine("=== ИМЕНА ===");
                Console.WriteLine();

                Name name1 = new Name("Клеопатра");
                Name name2 = new Name("Пушкин", "Александр", "Сергеевич");
                Name name3 = new Name("Маяковский", "Владимир");

                Console.WriteLine("Примеры из условия задачи:");
                Console.WriteLine("1. " + name1);
                Console.WriteLine("2. " + name2);
                Console.WriteLine("3. " + name3);

                Console.WriteLine();
                Console.WriteLine("=== Ввод имени пользователем ===");
                Name userName = CreateNameFromInput();
                Console.WriteLine();
                Console.WriteLine("Введенное имя: " + userName);

                Console.WriteLine();
                Console.WriteLine("Нажмите любую клавишу для возврата в меню...");
                Console.ReadKey();
            }

            static void ShowPersonTask()
            {
                Console.Clear();
                Console.WriteLine("=== ЧЕЛОВЕК ===");
                Console.WriteLine();

                Person person1 = new Person("Клеопатра", 152);
                Person person2 = new Person("Пушкин", 167);
                Person person3 = new Person("Владимир", 189);

                Console.WriteLine("Примеры из условия задачи:");
                Console.WriteLine("1. " + person1);
                Console.WriteLine("2. " + person2);
                Console.WriteLine("3. " + person3);

                Console.WriteLine();
                Console.WriteLine("=== Ввод данных человека пользователем ===");
                Person userPerson = CreatePersonFromInput();
                Console.WriteLine();
                Console.WriteLine("Введенный человек: " + userPerson);

                Console.WriteLine();
                Console.WriteLine("Нажмите любую клавишу для возврата в меню...");
                Console.ReadKey();
            }

            static void ShowPersonWithNameTask()
            {
                Console.Clear();
                Console.WriteLine("=== ЧЕЛОВЕК С ИМЕНЕМ ===");
                Console.WriteLine();

                PersonWithName person1 = new PersonWithName("Клеопатра", 152);
                PersonWithName person2 = new PersonWithName("Пушкин", "Александр", "Сергеевич", 167);
                PersonWithName person3 = new PersonWithName("Маяковский", "Владимир", 189);

                Console.WriteLine("Примеры из условия задачи:");
                Console.WriteLine("1. " + person1);
                Console.WriteLine("2. " + person2);
                Console.WriteLine("3. " + person3);

                Console.WriteLine();
                Console.WriteLine("=== Ввод данных человека с именем пользователем ===");
                PersonWithName userPerson = CreatePersonWithNameFromInput();
                Console.WriteLine();
                Console.WriteLine("Введенный человек: " + userPerson);

                Console.WriteLine();
                Console.WriteLine("Нажмите любую клавишу для возврата в меню...");
                Console.ReadKey();
            }

            static void ShowCityTask()
            {
                Console.Clear();
                Console.WriteLine("=== ГОРОДА ===");
                Console.WriteLine();

                City cityA = new City("A");
                City cityB = new City("B");
                City cityC = new City("C");
                City cityD = new City("D");
                City cityE = new City("E");
                City cityF = new City("F");

                cityA.AddRoute(cityB, 5);
                cityA.AddRoute(cityF, 1);
                cityA.AddRoute(cityD, 6);

                cityF.AddRoute(cityB, 1);
                cityF.AddRoute(cityE, 2);

                cityE.AddRoute(cityF, 2);

                cityB.AddRoute(cityC, 3);

                cityC.AddRoute(cityD, 4);

                cityD.AddRoute(cityE, 2);

                Console.WriteLine("Схема городов и путей:");
                Console.WriteLine(cityA);
                Console.WriteLine(cityB);
                Console.WriteLine(cityC);
                Console.WriteLine(cityD);
                Console.WriteLine(cityE);
                Console.WriteLine(cityF);

                Console.WriteLine();
                Console.WriteLine("Нажмите любую клавишу для возврата в меню...");
                Console.ReadKey();
            }

            static void ShowCreateCityTask()
            {
                Console.Clear();
                Console.WriteLine("=== СОЗДАЕМ ГОРОДА ===");
                Console.WriteLine();

                Console.WriteLine("1. Создание города только с названием:");
                City simpleCity = new City("ПростойГород");
                Console.WriteLine(simpleCity);

                Console.WriteLine();
                Console.WriteLine("2. Создание города с маршрутами через конструктор:");

                City cityA = new City("A");
                City cityB = new City("B");
                City cityC = new City("C");

                Route[] routes = new Route[]
                {
                new Route(cityA, 5),
                new Route(cityB, 3),
                new Route(cityC, 7)
                };

                City cityWithRoutes = new City("ГородСМаршрутами", routes);
                Console.WriteLine(cityWithRoutes);

                Console.WriteLine();
                Console.WriteLine("3. Создание полной схемы новыми конструкторами:");

                City newCityD = new City("D");
                City newCityC = new City("C", new Route[] { new Route(newCityD, 4) });
                City newCityE = new City("E", new Route[] { new Route(newCityD, 2) });
                City newCityB = new City("B", new Route[] { new Route(newCityC, 3) });

                Route[] routesForF = new Route[]
                {
                new Route(newCityB, 1),
                new Route(newCityE, 2)
                };
                City newCityF = new City("F", routesForF);

                Route[] routesForA = new Route[]
                {
                new Route(newCityB, 5),
                new Route(newCityF, 1),
                new Route(newCityD, 6)
                };
                City newCityA = new City("A", routesForA);

                Console.WriteLine("Схема городов, созданная новыми конструкторами:");
                Console.WriteLine(newCityA);
                Console.WriteLine(newCityB);
                Console.WriteLine(newCityC);
                Console.WriteLine(newCityD);
                Console.WriteLine(newCityE);
                Console.WriteLine(newCityF);

                Console.WriteLine();
                Console.WriteLine("Нажмите любую клавишу для возврата в меню...");
                Console.ReadKey();
            }

            static Name CreateNameFromInput()
            {
                Console.WriteLine();
                Console.WriteLine("Введите данные для создания имени (можно оставлять поля пустыми):");

                string lastName = GetInput("Фамилия");
                string firstName = GetInput("Имя");
                string middleName = GetInput("Отчество");

                return new Name(lastName, firstName, middleName);
            }

            static Person CreatePersonFromInput()
            {
                Console.WriteLine();
                Console.WriteLine("Введите данные для создания человека:");

                string name = GetInput("Имя");
                int height = GetIntegerInput("Рост");

                return new Person(name, height);
            }

            static PersonWithName CreatePersonWithNameFromInput()
            {
                Console.WriteLine();
                Console.WriteLine("Введите данные для создания человека с именем:");

                Console.WriteLine("Введите компоненты имени (можно оставлять поля пустыми):");
                string lastName = GetInput("Фамилия");
                string firstName = GetInput("Имя");
                string middleName = GetInput("Отчество");

                int height = GetIntegerInput("Рост");

                return new PersonWithName(lastName, firstName, middleName, height);
            }

            static string GetInput(string fieldName)
            {
                Console.Write(fieldName + ": ");
                string input = Console.ReadLine();

                if (input == null || input == "")
                {
                    return "";
                }

                return input;
            }

            static int GetIntegerInput(string fieldName)
            {
                while (true)
                {
                    Console.Write(fieldName + " (целое число): ");
                    string input = Console.ReadLine();

                    if (int.TryParse(input, out int number))
                    {
                        return number;
                    }
                    else
                    {
                        Console.WriteLine("Ошибка! Введите целое число для " + fieldName + ".");
                    }
                }
            }
        }
    }
