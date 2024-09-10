using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharp_Learn.Scripts.TaskesList
{
    class test
    {
        public void Massive()
        {
            // Работа с массивом:
            // Создание массива из 5 элементов
            int[] nums = new int[5];

            // Заполнение массива
            nums[0] = 10;
            nums[1] = 20;
            nums[2] = 30;
            nums[3] = 40;
            nums[4] = 50;

            //Console.WriteLine(nums[0]);

            int sum = 0;
            // Вывод элементов массива
            foreach (int num in nums)
            {
                sum = +num;
                Console.WriteLine(sum);
            }
        }

        public void List()
        {
            // Работа с списком:
            List<int> numbers = new List<int> { 10, 20, 30, 40, 50 };

            // Добавление нового элемента
            numbers.Add(60);

            //int adc = int.Parse(Console.ReadLine());
            //numbers.Add(adc);

            // Удаление элемента
            numbers.Remove(20);

            // Поиск элемента
            // Console.Write("Напишите искомую цыфру: ");
            int a = 30; // Можно использовать int.Parse(Console.ReadLine)
            if (numbers.Contains(a)) Console.WriteLine("Элемент найден");

            // Доступ ко всем элементам
            foreach (int number in numbers) Console.WriteLine(number);















            List<int> nums = new List<int>();

            nums.Add(1);
            nums.Add(3);
            nums.Add(5);
            nums.Add(4);
            nums.Add(2);

            Console.WriteLine("До сортировки: ");
            for (int i = 0; i < nums.Count; i++)
            { // 1 3 5 4 2
                Console.WriteLine(nums[i]);
            }


            Console.WriteLine();
            Console.WriteLine("После сортировки: ");
            nums.Sort(); // 1 2 3 4 5
            for (int i = 0; i < nums.Count; i++)
            {
                Console.WriteLine(nums[i]);
            }


            Console.WriteLine();
            Console.WriteLine("Вывод конкретного числа: ");
            int targget = 2;
            if (nums.Contains(targget))
                Console.WriteLine(targget);


            Console.WriteLine();
            Console.WriteLine("Поиск через цикл: ");
            int index = -1;
            //bool foundes = false;
            for (int i = 0; i < nums.Count; i++)
            {
                if (nums[i] == targget)
                {
                    //foundes = true;
                    index = i;
                    break;
                }
            }


            if (index == -1)
            {
                Console.WriteLine("Число не найдено!");
            }
            else
            {
                Console.WriteLine(targget);
            }










            // Создать список с цифрами.
            // Написать код, который выведет все места на которых замечена '1'.
            Console.WriteLine();
            List<int> numes = new List<int> { 1, 5, 5, 3, 1, 2, 3, 1 };

            int target = 1;
            bool foundes = false;

            for (int i = 0; i < numes.Count; i++)
            {
                if (numes[i] == target)
                {
                    Console.WriteLine($"Найдено число '1' на позициях '{i}'");
                    foundes = true;
                }
            }
        }

        public void Dictionary()
        {
            Dictionary<string, int> ages = new Dictionary<string, int>
            {
                { "Alice", 30 }, // { Ключ, значение }
                { "Bob", 25 },
                { "Charlie", 35 }
            };

            // Выводим возраст Alice
            Console.WriteLine($"Alice's age: {ages["Alice"]}");

            // Проверяем наличие ключа и выводим возраст Bob
            if (ages.ContainsKey("Bob"))
            {
                Console.WriteLine($"Bob's age: {ages["Bob"]}");
            }

            // Удаляем элемент
            ages.Remove("Charlie");

            //ages.Add("Приключение электроника", 57);

            // Выводим все пары ключ-значение
            foreach (var pair in ages)
            {
                // $ - используется для упращённого ввода переменных для вывода.
                // Вместо более длинного варианта Console.WriteLine(pair.Key + ": " + {pair.Value});
                Console.WriteLine($"{pair.Key}: {pair.Value}");
            }

            Console.WriteLine();
            Dictionary<string, int> ageb = new Dictionary<string, int>
            {
                { "Юрий", 36 }, // { Ключ, значение }
                { "Фома", 52 },
                { "Тома", 19 }
            };

            string nameKey = "Юр";
            bool found = false;

            foreach (var pair in ageb)
            {
                if (pair.Key.Contains(nameKey))
                {
                    // $ - используется для упращённого ввода переменных для вывода.
                    // Вместо более длинного варианта Console.WriteLine(pair.Key + ": " + {pair.Value});
                    Console.WriteLine($"Имя: {pair.Key}. Возраст: {pair.Value}");

                    found = true;
                    break;
                }
            }
            if (!found)
            {
                Console.WriteLine($"Имя не найдено, с таким содержанием: '{nameKey}'");
            }

            Console.WriteLine();
            // Выводим возраст Alice
            Console.WriteLine($"Возраст Фомы: {ages["Фома"]}");

            Console.WriteLine();
            // Проверяем наличие ключа и выводим возраст Юрия
            if (ages.ContainsKey("Юрий"))
            {
                Console.WriteLine($"Возраст Юрия: {ages["Юрий"]}");
            }

            Console.WriteLine();
            // Удаляем элемент
            ages.Remove("Фома");

            // Выводим все пары ключ-значение
            foreach (var pair in ages)
            {
                Console.WriteLine($"{pair.Key}: {pair.Value}");
            }
            // Надо сделать цикл для поиска и вывода нужного значения, которое находится в списке, и в словаре.
            Console.WriteLine();
            Dictionary<string, int> age = new Dictionary<string, int>
            {
                { "Андрей", 12 },
                { "Егор", 17 }
            };

            if (age.ContainsKey("Андрей"))
                Console.WriteLine($"Возраст Андрея: {age["Андрей"]}");

            Console.WriteLine();
            List<int> numbers = new List<int> { 1, 2, 3, 4, 5 };

            int a = 4;
            if (numbers.Contains(a))
                Console.WriteLine("Число найдено!");









            // Создать новый словарь с несколькими элементами. (Имя возрост)
            // Написать код, который выводит все ключи начинающиеся на букву 'Ю'.
            // Поиск имён: Юра, Юрей, Юля.
            Dictionary<string, int> keyValuePairs = new Dictionary<string, int>
            {
                { "Наталья", 15 },
                { "Юра", 15 },
                { "Юля", 15 },
                { "Ёрик", 15 },
                { "Юрей", 15 }
            };

            string nameBKey = "Ю";
            // string nameKey = Console.ReadLine();
            bool founds = false;

            foreach (var pair in keyValuePairs)
            {
                // Contains - Содержание символа в ключах.
                // StartsWith - Начальный символ.
                if (pair.Key.StartsWith(nameKey))
                {
                    Console.WriteLine($"Имя: {pair.Key}. Возраст: {pair.Value}");
                    found = true;
                }
            }
            if (!found)
                Console.WriteLine($"Имя не найдено, с таким содержанием: '{nameKey}'");

        }
    }
}
