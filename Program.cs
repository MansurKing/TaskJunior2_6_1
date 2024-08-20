using System;

namespace TaskJunior2._6
{
    class Program
    {
        static void Main(string[] args)
        {
            const string CommandRublToDollar = "1";
            const string CommandDollarToRubl = "2";
            const string CommandRublToYuan = "3";
            const string CommandYuanToRubl = "4";
            const string CommandRublToEuro = "5";
            const string CommandEuroToRubl = "6";
            const string CommandCleaningConsole = "7";
            const string CommandExitFromConsole = "8";

            string userInput;

            float rublToDollar = 90.20f;
            float dollarToRubl = 85.70f;
            float rublToYuan = 13.16f;
            float yuanToRubl = 11.83f;
            float rublToEuro = 101.40f;
            float euroToRubl = 96.20f;
            float rublesInWallet;
            float dollarsInWallet;
            float yuanInWallet;
            float euroInWallet;
            float exchangeCurrencyCount;

            bool isWork = true;

            Console.WriteLine("Добро пожаловать в обменник валют.");

                        Console.Write("Введите баланс рублей: ");
                        rublesInWallet = Convert.ToSingle(Console.ReadLine());

                        Console.Write("Введите баланс долларов: ");
                        dollarsInWallet = Convert.ToSingle(Console.ReadLine());

                        Console.Write("Введите баланс юаней: ");
                        yuanInWallet = Convert.ToSingle(Console.ReadLine());

                        Console.Write("Введите баланс евро: ");
                        euroInWallet = Convert.ToSingle(Console.ReadLine());

            while (isWork)
            {
                Console.WriteLine("\nВыберете следующую команду: \n" +
                                 $"{CommandRublToDollar} - Обмен рублей на доллары: \n" +
                                 $"{CommandDollarToRubl} - Обмен доллоров на рубли: \n" +
                                 $"{CommandRublToYuan} - Обмен рублей на юани: \n" +
                                 $"{CommandYuanToRubl} - Обмен юаней на рубли: \n" +
                                 $"{CommandRublToEuro} - Обмен рублей на евро: \n" +
                                 $"{CommandEuroToRubl} - Обмен евро на рубли: \n" +
                                 $"{CommandCleaningConsole} - Очистка консоли.\n" +
                                 $"{CommandExitFromConsole} - Выход.\n");
                userInput = Console.ReadLine();

                switch (userInput)
                {
                    case CommandRublToDollar:

                        Console.WriteLine("Обмен рублей на доллары.");

                        Console.Write("\nСколько вы хотите обменять: ");
                        exchangeCurrencyCount = Convert.ToSingle(Console.ReadLine());

                        if (rublesInWallet >= exchangeCurrencyCount)
                        {
                            rublesInWallet -= exchangeCurrencyCount;
                            dollarsInWallet += exchangeCurrencyCount / rublToDollar;
                        }
                        else
                        {
                            Console.WriteLine("Недопустимое кол-во рублей!\n");
                        }

                        Console.WriteLine($"\nВаш баланс: \n{rublesInWallet} рублей, \n{dollarsInWallet} долларов.\n" +
                                          $"{yuanInWallet} юаней,\n{euroInWallet} евро.\n");

                        break;

                    case CommandDollarToRubl:

                        Console.WriteLine("Обмен долларов на рубли.");

                        Console.Write("\nСколько вы хотите обменять: ");
                        exchangeCurrencyCount = Convert.ToSingle(Console.ReadLine());

                        if (dollarsInWallet >= exchangeCurrencyCount)
                        {
                            dollarsInWallet -= exchangeCurrencyCount;
                            rublesInWallet += exchangeCurrencyCount * dollarToRubl;
                        }
                        else
                        {
                            Console.WriteLine("Недопустимое кол-во долларов!\n");
                        }

                        Console.WriteLine($"\nВаш баланс: \n{rublesInWallet} рублей, \n{dollarsInWallet} долларов.\n" +
                                          $"{yuanInWallet} юаней,\n{euroInWallet} евро.\n");

                        break;

                    case CommandRublToYuan:

                        Console.WriteLine("Обмен рублей на юани.");

                        Console.Write("\nСколько вы хотите обменять: ");
                        exchangeCurrencyCount = Convert.ToSingle(Console.ReadLine());

                        if (rublesInWallet >= exchangeCurrencyCount)
                        {
                            rublesInWallet -= exchangeCurrencyCount;
                            yuanInWallet += exchangeCurrencyCount / rublToYuan;
                        }
                        else
                        {
                            Console.WriteLine("Недопустимое кол-во рублей!\n");
                        }

                        Console.WriteLine($"\nВаш баланс: \n{rublesInWallet} рублей, \n{yuanInWallet} юаней,\n" +
                                          $"{dollarsInWallet} долларов,\n{euroInWallet} евро.\n");

                        break;

                    case CommandYuanToRubl:

                        Console.WriteLine("Обмен юаней на рубли.");

                        Console.Write("\nСколько вы хотите обменять: ");
                        exchangeCurrencyCount = Convert.ToSingle(Console.ReadLine());

                        if (yuanInWallet >= exchangeCurrencyCount)
                        {
                            yuanInWallet -= exchangeCurrencyCount;
                            rublesInWallet += exchangeCurrencyCount * yuanToRubl;
                        }
                        else
                        {
                            Console.WriteLine("Недопустимое кол-во юаней!\n");
                        }

                        Console.WriteLine($"\nВаш баланс: \n{rublesInWallet} рублей, \n{yuanInWallet} юаней,\n" +
                                          $"{dollarsInWallet} долларов,\n{euroInWallet} евро.\n");

                        break;

                    case CommandRublToEuro:

                        Console.WriteLine("Обмен рублей на евро.");

                        Console.Write("\nСколько вы хотите обменять: ");
                        exchangeCurrencyCount = Convert.ToSingle(Console.ReadLine());

                        if (rublesInWallet >= exchangeCurrencyCount)
                        {
                            rublesInWallet -= exchangeCurrencyCount;
                            euroInWallet += exchangeCurrencyCount / rublToEuro;
                        }
                        else
                        {
                            Console.WriteLine("Недопустимое кол-во рублей!\n");
                        }

                        Console.WriteLine($"\nВаш баланс: \n{rublesInWallet} рублей, \n{euroInWallet} евро,\n" +
                                          $"{yuanInWallet} юаней,\n{dollarsInWallet} долларов.\n");

                        break;

                    case CommandEuroToRubl:

                        Console.WriteLine("Обмен евро на рубли.");

                        Console.Write("\nСколько вы хотите обменять: ");
                        exchangeCurrencyCount = Convert.ToSingle(Console.ReadLine());

                        if (euroInWallet >= exchangeCurrencyCount)
                        {
                            euroInWallet -= exchangeCurrencyCount;
                            rublesInWallet += exchangeCurrencyCount * euroToRubl;
                        }
                        else
                        {
                            Console.WriteLine("Недопустимое кол-во евро!\n");
                        }

                        Console.WriteLine($"\nВаш баланс: \n{rublesInWallet} рублей, \n{euroInWallet} евро,\n" +
                                          $"{yuanInWallet} юаней,\n{dollarsInWallet} долларов.\n");

                        break;

                    case CommandCleaningConsole:

                        Console.Clear();

                        break;

                    case CommandExitFromConsole:

                        isWork = false;
                        Console.WriteLine("Программа завершена.");

                        break;

                    default:

                        Console.WriteLine("Вы ввели не верную комманду!!!\n" +
                                          "Введите номер команды предложенных ниже)))\n");

                        break;
                }
            }
        }
    }
}
