using System;
using System.Linq;

namespace Cities
{
    class Program
    {
        static string[] usedCities = { }; // уже названные города
        static int count = 0;
        static int badCount = 0;

        static void Main()
        {
            string currentCity = ReadCities.citiesList[666];
            
            Console.WriteLine("Добро пожаловать в игру \"Города\"\n" +
                "Правила просты: пишите город, название которого начинается с буквы, \n" +
                "которой заканчивается название предыдущего города.\n" +
                "За каждую ошибку Вы получаете штраф. 3 штрафа - выход из игры.\n" +
                "За каждый верный город Вы будете получать 1 очко.\n" +
                "Удачи!\n\n");

            Console.Write($"Первый город - {currentCity}\n"); 
            while(true)
            {
                Console.Write($"\nВведите город на букву \"{currentCity[0]}\": ");
                string users_city = Console.ReadLine();
                if (!task3.FindCities(users_city) || users_city[0] != currentCity[0] || usedCities.Contains(users_city))
                {
                    badCount++;
                    Console.WriteLine("Неправильно!\n" +
                        $"Количество штрафов: {badCount}\n" +
                        $"Попробуйте ввести город снова: ");
                    if (badCount == 3)
                    {
                        Console.WriteLine("Игра окончена, у Вас 3 штрафа. \n" +
                            $"Ваш счёт: {count}");
                        break;
                    }
                    continue;
                }
                Console.WriteLine($"Отлично! Вы получаете 1 очко. Всего очков: {count}");
                usedCities.Append(users_city);
                currentCity = task4.FindCity(users_city[users_city.Length - 1]);
                Console.WriteLine($"Следующий город - {currentCity}");

            }
        }
    }
}
