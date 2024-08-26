using System;
using System.Diagnostics.CodeAnalysis;
using System.Globalization;
using System.Reflection;
using System.Security.Cryptography.X509Certificates;
using System.Xml.Linq;

class Months_Learn
{
    static void Main()
    {

        // 1 Day

        /* Переменные
        int a = 10;
        double b = 5.1;
        char c = 'a';
        string d = "Hello";
        bool e = true;
        Console.WriteLine(a + b);
        Console.WriteLine(c);
        Console.WriteLine(d);
        Console.WriteLine(e);
        */

        /* Ввод, вывод текста в консоль.
        Console.Write("Введите имя: ");
        string name = Console.ReadLine();
        Console.WriteLine("Привет, " + name + "!");
        */

        /* Условия для выполнения некоторого кода.
        int num = 1;

        if (num > 0)
        {
            Console.WriteLine("Позитив");
        }
        else if (num < 0)
        {
            Console.WriteLine("Негатив");
        }
        else
        {
            Console.WriteLine("Ноль");
        }

        switch (num)
        {
            case 1:
                Console.WriteLine("Один");
                break;
            case 2:
                Console.WriteLine("Два");
                break;
            default:
                Console.WriteLine("Это явно другое число...");
                break;
        }
        */

        /* Циклы
        for (int i = 0; i < 5; ++i)
        {
            Console.WriteLine("For loop: " + i);
        }

        int j = 0;
        while (j < 5)
        {
            Console.WriteLine("While loop: " + j);
            j++;
        }

        int k = 0;
        do
        {
            Console.WriteLine("Do-while loop: " + k);
            k++;
        }
        while (k < 5);
        */






        /* В структуре int есть следующие методы:
         * 
         * 1. int.Equals() — используется для проверки, равны ли два объекта int. Возвращает логическое значение.
         * 2. int.Parse() — используется для преобразования или анализа строки в int.
         * 3. int.MaxValue — возвращает максимальное возможное значение переменной int.
         * 4. int.MinValue — возвращает миниимальное возможное значение переменной int.
         * 
        */

        /* Задание 1: Напишите программу, которая запрашивает у пользователя два числа, складывает их и выводит результат на экран. (Выполнено)
        
        Console.Write("1-е число: "); // Пользовательский ввод числа.
        int a = int.Parse(Console.ReadLine()); // Преобразование числа из string в integer.

        Console.Write("2-е число: ");
        int b = int.Parse(Console.ReadLine());

        Console.WriteLine(a + b); // Вывод суммы
        */






        /* Задание 2: Напишите программу, которая запрашивает у пользователя число и определяет, является ли оно четным или нечетным. (Выполнено)

        Console.Write("Напишите число: "); // Пользовательский ввод числа.
        int num = int.Parse(Console.ReadLine()); // Преобразование числа из string в integer.

        if (num % 2 == 0) // Если число чётное.
        {
            Console.WriteLine("Число четное.");
        }
        else // Если число не чётное.
        {
            Console.WriteLine("Число не четное.");
        }
        */






        /* Задание 3: Напишите программу, которая выводит таблицу умножения для чисел от 1 до 10. (Выполнено)

        for (int i = 1; i < 11; i++) // Задаём условия (int чему число равно; Минимум или максимум; Уменьшение или увеличение числа)
        {
            Console.WriteLine(i + " * 1 = " + i * 1);
            Console.WriteLine(i + " * 2 = " + i * 2);
            Console.WriteLine(i + " * 3 = " + i * 3);
            Console.WriteLine(i + " * 4 = " + i * 4);
            Console.WriteLine(i + " * 5 = " + i * 5);
            Console.WriteLine(i + " * 6 = " + i * 6);
            Console.WriteLine(i + " * 7 = " + i * 7);
            Console.WriteLine(i + " * 8 = " + i * 8);
            Console.WriteLine(i + " * 9 = " + i * 9);
            Console.WriteLine(i + " * 10 = " + i * 10);
        }
        */






        /* Задание 4: Напишите программу, которая запрашивает у пользователя три числа и выводит наибольшее из них. (Выполнено)

        Console.Write("1-е число: "); // Пользовательский ввод числа.
        int a = int.Parse(Console.ReadLine()); // Преобразование числа из string в integer.

        Console.Write("2-е число: ");
        int b = int.Parse(Console.ReadLine());

        Console.Write("3-е число: ");
        int c = int.Parse(Console.ReadLine());

        if (a < b) // 12
        {
            if (b < c) // 23
            {
                Console.WriteLine("Это число наибольшее: " + c);
            }
            else if(c < a) // 31
            {
                Console.WriteLine("Это число наибольшее: " + b);
            }
        }

        else if (b < a) // 21
        {
            if (b < c) // 23
            {
                Console.WriteLine("Это число наибольшее: " + c);
            }
            else if (c < a) // 31
            {
                Console.WriteLine("Это число наибольшее: " + b);
            }
        }

        else if (a < c) // 13
        {
            if (b < c) // 23
            {
                Console.WriteLine("Это число наибольшее: " + c);
            }
            else if (b < a) // 21
            {
                Console.WriteLine("Это число наибольшее: " + b);
            }
        }
        */






        /* Задание 5: Напишите программу, которая запрашивает у пользователя число N и считает сумму чисел от 1 до N.. (+- Выполнено)

        Console.Write("Напишите целое число (не меньше 1): "); // Пользовательский ввод числа.
        int n = int.Parse(Console.ReadLine()); // Преобразование числа из string в integer.
        int sum = 0;
        for (int i = 2; i <= n; i++) 
        {
            sum += i;
        }
        Console.WriteLine(sum);
        */

























        // Day 2

        // int age = 19;
        /* В структуре int есть следующие методы:
         * 
         * 1. int.Equals() — используется для проверки, равны ли два объекта int. Возвращает логическое значение.
         * 2. int.Parse() — используется для преобразования или анализа строки в int.
         * 3. int.MaxValue — возвращает максимальное возможное значение переменной int.
         * 4. int.MinValue — возвращает миниимальное возможное значение переменной int.
         * 
        */

        // double height = 5.7; // Это около 1.8м. double может уточнить до 15 цыфр после запятой, но не является самым точным.

        // string name = "Alice";
        /* В структуре string есть следующие методы:
         * 
         * Compare: сравнивает две строки с учетом текущей культуры (локали) пользователя
         * CompareOrdinal: сравнивает две строки без учета локали
         * Contains: определяет, содержится ли подстрока в строке
         * Concat: соединяет строки
         * CopyTo: копирует часть строки, начиная с определенного индекса в массив
         * EndsWith: определяет, совпадает ли конец строки с подстрокой
         * Format: форматирует строку
         * IndexOf: находит индекс первого вхождения символа или подстроки в строке
         * Insert: вставляет в строку подстроку
         * Join: соединяет элементы массива строк
         * LastIndexOf: находит индекс последнего вхождения символа или подстроки в строке
         * Replace: замещает в строке символ или подстроку другим символом или подстрокой
         * Split: разделяет одну строку на массив строк
         * Substring: извлекает из строки подстроку, начиная с указанной позиции
         * ToLower: переводит все символы строки в нижний регистр
         * ToUpper: переводит все символы строки в верхний регистр
         * Trim: удаляет начальные и конечные пробелы из строки
         * 
        */

        // bool isStudent = true;

        // int a = 1;
        // int b = 2;
        // int c = a + b;
        // bool isEqual = a == b;
        /* В структуре bool есть следующие методы:
         * 
         * Доступны четыре оператора сравнения:
         * Больше, чем (>).
         * Меньше (<).
         * Больше или равно (>=).
         * Меньше или равно (<=).
         * Строго равно (==).
         * Строго не равно (!=).
         * Истина (true).
         * Не истина (false).
         * 
        */
        // bool isGreeterThan = a > b && b < 15;

        // Console.WriteLine("Введите своё имя: ");
        // string name = Console.ReadLine();
        // Console.WriteLine("Привет, " + name + "!");

        // Console.WriteLine("Введите число с точностью до 3 после точки: ");
        // double num = double.Parse(Console.ReadLine()); // Не только int.Parse(), но ещё есть double.Parse()
        // Console.WriteLine("Ваше число: " + num);





        // Тренеровка перед практикой: 
        /*
        Console.WriteLine("Ваше имя: ");
        string name = Console.ReadLine();

        Console.WriteLine("Ваш возраст: ");
        int age = int.Parse(Console.ReadLine());

        Console.WriteLine("Ваше десятичное число: ");
        double any_num = double.Parse(Console.ReadLine());

        Console.WriteLine("Вас зовут: " + name + ". Ваш возраст: " + age + ". Ваше число: " + any_num);

        Console.WriteLine("1-е число для суммы: ");
        double a = double.Parse(Console.ReadLine());

        Console.WriteLine("2-е число для суммы: ");
        double b = double.Parse(Console.ReadLine());

        double c = a + b;

        Console.WriteLine(a + " + " + b + " = " + c); // Плюс нужен для того чтобы можно было соединить переменные с строкой. В Python так не работает.
        */

        /*
        Console.WriteLine("Напишите оператор сравнения: ");

        switch (Console.ReadLine())
        {
            case "<=":
                Console.WriteLine("1-е число");
                int a = int.Parse(Console.ReadLine());

                Console.WriteLine("2-е число");
                int b = int.Parse(Console.ReadLine());

                if (b < a) if (a > b)
                {
                    Console.WriteLine(a + " больше чем " + b + " и " + b + " меньше чем " + a);
                }
                else if (a < b)
                {
                    Console.WriteLine(a + " меньше чем " + b);
                }
                else
                {
                    Console.WriteLine("Ваши числа равны.");
                }
                break;

            case "<":
                Console.WriteLine("1-е число");
                int c = int.Parse(Console.ReadLine());

                Console.WriteLine("2-е число");
                int d = int.Parse(Console.ReadLine());

                if (d > c)
                {
                    Console.WriteLine(d + " больше чем " + c);
                }
                else if (d < c)
                {
                    Console.WriteLine(d + " меньше чем " + c);
                }
                else
                {
                    Console.WriteLine("Ваши числа равны.");
                }
                break;
        }
        */

        /*
        Console.WriteLine("Ваше целое число: ");
        int a = int.Parse(Console.ReadLine());

        if (a % 2 == 0)
        {
            Console.WriteLine("Число четное.");
        }
        else
        {
            Console.WriteLine("Число не четное.");
        }

        Console.WriteLine("1-е число: ");
        int b = int.Parse(Console.ReadLine());

        Console.WriteLine("2-е число: ");
        int c = int.Parse(Console.ReadLine());

        int d = b + c;
        Console.WriteLine("Сумма чисел равна: " + d);
        */

        // Практику для закрепления 2 дня не смог найти, т.к. все примеры выше похожу по состовляющему на 1-й день.

























        // Day 3
        // Теперь вместо повторения пактик я пишу код под 1 тему несколько разных задач меняя текст или кол-во строк для одной программы.
        // Это касается последующих дней, для лучшего запоминания кода и разработки своей логики.

        /*
        Console.Write("Ваше число: ");
        int a = int.Parse(Console.ReadLine());

        if (a > 0) Console.WriteLine("Ваше число положительное.");
        else if (a == 0) Console.WriteLine("Это ноль.");
        else Console.WriteLine("Ваше число отрицательное.")

        Console.Write("Ваша оценка: ");
        int b = int.Parse(Console.ReadLine());

        if (b > 80) Console.WriteLine("Ваша оценка отличная.");
        else if (b > 50) Console.WriteLine("Ваша оценка хорошая.");
        else if (b > 30) Console.WriteLine("Ваша оценка средняя.");
        else Console.WriteLine("Ваша оценка плохая.");

        Console.Write("Ваше число: ");
        int с = int.Parse(Console.ReadLine());
        Console.Write("Степень вашего числа: ");
        int d = int.Parse(Console.ReadLine());

        if (c < 0) Console.WriteLine("Программа не умеет считать отрицательные числа.");
        else if (d < 0) Console.WriteLine("Программа не умеет считать отрицательные степени чисел.");
        else cd = c ** d; Console.WriteLine("Ответ: " +  cd);
        */

























        // Day 4
        // for - это цикл с обозначением счётчика, условия срабатывания и процесс цикла, а дальше функция для использования заданных перменных в цикле.
        // for (int i = 0; i < 10; i++) Console.WriteLine(i);

        // int i = 0;
        // while - цикл с 1 условием и телом цикла.
        // while (i < 10) Console.WriteLine(i); i++;

        // int i = 0;
        // do while - Цикл который вначале выполняется, а после сравнивает условие для последующего выполнения.
        // do {Console.WriteLine(i); i++;} while (i < 10)





        // Подготовка к практике:
        /*
        for (int i = 0; i < 10; i++)
        {
            if (i == 5) 
            {
                break; // Прерывание цикла.
            }
            Console.WriteLine(i);
        }

        for (int i = 0; i < 10; i++)
        {
            if (i == 5) 
            {
                continue; // Переход к следующему шагу.
            }
            Console.WriteLine(i);
        }
        */

        // for (int i = 0; i < 101; i++) Console.WriteLine(i);

        /*
        Console.Write("Напишите число: ");
        int a = int.Parse(Console.ReadLine());
        for (int i = 1; i < 11; i++) Console.WriteLine(i + " * " + a);
        */

        // int a = 0;
        // while (a < 101) Console.WriteLine(a);
        // do {Console.WriteLine(i + " * " + a); i++;} while (i <= 10)





        // Практика:
        /*
        for (int i = 0; i < 11; i++)
        {
            Console.WriteLine(i);
            if (i == 5)
            {
                break;
            }
        }
        */

        /*
        for (int i = 0; i < 11; i++)
        {
            if (i % 2 == 0)
            {
                Console.WriteLine(i);
            }
        }
        */

























        // 5 Day
        // 
        // Сильно опаздываю по выкладыванию кода, но по прежнему в свободное время делаю всё что мог бы сделать за прошлые дни...
        // Если кто заглянет сюда, можете свои задачи кидать мне в телеграмм: seqjo
        // 
        // Вызов функции запускает её код.
        /*
        void PrintMessage()
        {
            Console.WriteLine("Hi");
        }

        PrintMessage();
        */




        /*
        // Подготовка к практике:
        void PrintNumber()
        {
            int number = 9;
            Console.WriteLine(number);
        }

        PrintNumber();

        int AddNumber(int a, int b)
        {
            return a + b;
        }

        int result = AddNumber(1, 2);
        Console.WriteLine(result);

        int Add(int a, int b)
        {
            return a + b;
        }
        
        Console.WriteLine(Add(1, 15));
        
        double Add(double a, double b)
        {
            return a + b;
        }

        Console.WriteLine(Add(1.12, 1.817));

        void PrintNumbers(params int[] numbers)
        {
            foreach (int number in numbers)
            {
                Console.WriteLine(number);
            }
        }

        PrintNumbers(1, 2, 3, 4, 5, 6); // Передаём массив.

        void OuterFunction() // Вызов функции внутри которой есть функция, которая больше нигде не используется.
        {
            void InnerFunction()
            {
                Console.WriteLine("Почему я ни где не используюсь?");
            }

            InnerFunction(); // Вызов вспомогательной функции.
        }

        OuterFunction(); // Вызов первой функции.

        void Multiply()
        {
            int func(int a, int b) {return a * b;}
            Console.WriteLine(func(1, 2));

            double func(double a, double b) {return a * b;}
            Console.WriteLine(func(1.12, 1.817));
        }

        Multiply();

        */

























        // 6 Day - Массивы...
        /*
        // 1.Одномерные массивы
        Console.WriteLine("1.Одномерные массивы.");
        int[] numbers = new int[5]; // Объявление массива с 5 элементами
        numbers[0] = 1;
        numbers[1] = 2;
        numbers[2] = 3;
        numbers[3] = 4;
        numbers[4] = 5;

        // Альтернативный способ инициализации
        int[] numbers1 = { 1, 2, 3, 4, 5 };
        Console.WriteLine(numbers);





        // 2.Перебор массива с использованием цикла for
        Console.WriteLine("2.Перебор массива с использованием цикла for.");
        int[] nn = { 1, 2, 3, 4, 5 }; // nn.Length - длина массива nn
        for (int i = 0; i < nn.Length; i++) Console.WriteLine(nn[i]); // Вывод каждого числа из массива nn.






        // 3.Многомерные массивы
        Console.WriteLine("3.Многомерные массивы.");
        // int[,] 
        int[,] matrix = new int[3, 3]; // Объявление двумерного массива 3x3
        matrix[0, 0] = 1; // Двумерный массив под номером 1 0х0
        matrix[0, 1] = 2; // Двумерный массив под номером 2 0х1
        matrix[0, 2] = 3; // Двумерный массив под номером 3 0х2 и т.д.
        matrix[1, 0] = 4;
        matrix[1, 1] = 5;
        matrix[1, 2] = 6;
        matrix[2, 0] = 7;
        matrix[2, 1] = 8;
        matrix[2, 2] = 9;

        // Альтернативный способ инициализации
        int[,] otherMatrix = { { 1, 2, 3 }, { 4, 5, 6 }, { 7, 8, 9 } };
        Console.WriteLine();






        // 4.Перебор многомерного массива
        Console.WriteLine("4.Перебор многомерного массива.");

        int[,] matrixs = { { 1, 2, 3 }, { 4, 5, 6 }, { 7, 8, 9 } };

        for (int i = 0; i < matrixs.GetLength(0); i++)
        {
            for (int j = 0; j < matrixs.GetLength(1); j++)
            {
                Console.WriteLine(matrixs[i, j]);
            }
        }






        // 5.Основные операции над массивами
        Console.WriteLine("5.Основные операции над массивами.");

        int[] ns = { 5, 2, 8, 1, 3 };

        // Копирование массива
        int[] copy = new int[ns.Length];
        Array.Copy(ns, copy, ns.Length);

        // Сортировка массива
        Array.Sort(ns);

        // Поиск элемента в массиве
        int index = Array.IndexOf(ns, 8);
        Console.WriteLine("Index of 8: " + index);






        Console.WriteLine("ЗАДАЧИ:");
        Console.WriteLine();
        Console.WriteLine();
        // Задача 1: Напишите программу, которая запрашивает у пользователя два целых числа и выводит их сумму, разность, произведение и частное.
        Console.WriteLine("Задача 1: Напишите программу, которая запрашивает у пользователя два целых числа и выводит их сумму, разность, произведение и частное.");

        Console.WriteLine("Напишите 1-е число: ");
        int a = int.Parse(Console.ReadLine());

        Console.WriteLine("Напишите 2-е число: ");
        int b = int.Parse(Console.ReadLine());


        Console.WriteLine("Напишите арифметический знак: ");
        string c = Console.ReadLine();
        switch (c)
        {
            case "-":
                int dum = a - b;
                Console.WriteLine(dum);
                break;

            case "+":
                int sum = a + b;
                Console.WriteLine(sum);
                break;

            case "*":
                int umn = a * b;
                Console.WriteLine(umn);
                break;

            case "/":
                int del = a / b;
                Console.WriteLine(del);
                break;
        }






        // Задача 2: Напишите программу, которая запрашивает у пользователя его возраст и выводит сообщение с указанием, является ли он совершеннолетним.
        Console.WriteLine("Задача 2: Напишите программу, которая запрашивает у пользователя его возраст и выводит сообщение с указанием, является ли он совершеннолетним.");

        Console.WriteLine("Напишите свой возраст: ");
        int age = int.Parse(Console.ReadLine());

        if (age < 0) Console.WriteLine("Неверный возраст!");
        else if (age < 18) if (age > 0) Console.WriteLine("Вы ещё не совершено-летний человек.");
        else Console.WriteLine("Вы совершено-летний!");






        // Задача 3: Напишите программу, которая запрашивает у пользователя число и определяет, является ли оно четным или нечетным.
        Console.WriteLine("Задача 3: Напишите программу, которая запрашивает у пользователя число и определяет, является ли оно четным или нечетным.");

        Console.WriteLine("Напишите число: ");
        int numc = int.Parse(Console.ReadLine());

        if (numc % 2 == 0) Console.WriteLine("Число четное!");
        else Console.WriteLine("Число нечетное!");






        // Задача 4: Напишите программу, которая определяет, является ли введенное пользователем число положительным, отрицательным или нулем.
        Console.WriteLine("Задача 4: Напишите программу, которая определяет, является ли введенное пользователем число положительным, отрицательным или нулем.");

        Console.WriteLine("Напишите число: ");
        int chislo = int.Parse(Console.ReadLine());

        if (chislo == 0) Console.WriteLine("Число является нулём.");
        if (chislo > 0) Console.WriteLine("Число положительное.");
        else Console.WriteLine("Число отрицательное.");






        // Задача 5: Напишите программу, которая выводит все числа от 1 до 100, которые делятся на 3.
        Console.WriteLine("Задача 5: Напишите программу, которая выводит все числа от 1 до 100, которые делятся на 3.");

        for (int i = 0; i <= 100; i++) if (i % 3 == 0) Console.WriteLine(i);






        // Задача 6: Напишите программу, которая запрашивает у пользователя 5 чисел и выводит их среднее значение.
        Console.WriteLine("Задача 6: Напишите программу, которая запрашивает у пользователя 5 чисел и выводит их среднее значение.");

        Console.WriteLine("Напишите каждое число отдельно, используйте для разделения Enter.");
        int ac = int.Parse(Console.ReadLine());
        int bc = int.Parse(Console.ReadLine());
        int cc = int.Parse(Console.ReadLine());
        int ec = int.Parse(Console.ReadLine());
        int fc = int.Parse(Console.ReadLine());

        int umnc = (ac + bc + cc + ec + fc) / 5;
        Console.WriteLine(umnc);






        // Задача 7: Напишите функцию, которая принимает строку и возвращает ее длину.
        Console.WriteLine("Задача 7: Напишите функцию, которая принимает строку и возвращает ее длину.");

        Console.WriteLine("Напишите предложение:");
        string words = Console.ReadLine();
        foreach (var f in words)
        {
            for (int i = 0; i <= words.Length; i++)
            {
                Console.WriteLine(i);
            }
        }






        // Задача 8: Напишите программу, которая запрашивает у пользователя 10 чисел и сохраняет их в массиве.
        // Затем программа должна найти и вывести наибольшее и наименьшее число в массиве.

        // Задача 9: Напишите программу, которая создает двумерный массив 5x5 и заполняет его случайными числами.
        // Затем программа должна найти и вывести сумму всех элементов массива.

        // Задача 10: Напишите программу, которая запрашивает у пользователя количество студентов в классе, а затем запрашивает оценки каждого студента.
        // Программа должна вывести среднюю оценку класса.
        
        var HumonGGCount = new List<string>(); // Записываем количество учеников.

        Console.WriteLine("Напишите количество учеников в классе");
        var Humons = Console.ReadLine();
        var arg1 = Humons.Split(' ');
        HumonGGCount.Add(Humons);

        for (int i = 1; i <= HumonGGCount.Count; i++)
        {
            Console.WriteLine("Напишите оценки (через пробел) ученика под номером " + i + ".");
            var str = Console.ReadLine();
            var arg2 = str.Split(' ');
        }





        
        
        // Задача 11: Напишите программу, которая создает двумерный массив и выводит его в виде таблицы, затем находит и выводит сумму элементов каждой строки и каждого столбца.
        */









































        // Пример: 

        // Таблица умножения:
        /*
        for (int w = 1; w < 10; w++) 
        {
            for (int j = 1; j < 10; j++)
            {
                Console.Write($"{w * j} \t"); 
            }
        }




        // Работа с массивом:
        // Создание массива из 5 элементов
        int[] nums = new int[5];

        // Заполнение массива
        nums[0] = 10;
        nums[1] = 20;
        nums[2] = 30;
        nums[3] = 40;
        nums[4] = 50;

        int sum = 0;
        // Вывод элементов массива
        foreach (int num in nums)
        {
            sum =+ num;
            Console.WriteLine(sum);
        }




        // Работа с списком:
        List<int> numbers = new List<int> { 10, 20, 30, 40, 50 };

        // Добавление нового элемента
        numbers.Add(60);

        // Удаление элемента
        numbers.Remove(20);

        // Поиск элемента
        // Console.Write("Напишите искомую цыфру: ");
        int a = 30; // Можно использовать int.Parse(Console.ReadLine)
        if (numbers.Contains(a)) Console.WriteLine("Элемент найден");

        // Доступ ко всем элементам
        foreach (int number in numbers) Console.WriteLine(number);
        */




        /*
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

        // Выводим все пары ключ-значение
        foreach (var pair in ages)
        {
            // $ - используется для упращённого ввода переменных для вывода.
            // Вместо более длинного варианта Console.WriteLine(pair.Key + ": " + {pair.Value});
            Console.WriteLine($"{pair.Key}: {pair.Value}");
        }
        */



        /*
        List<int> nums = new List<int>();

        nums.Add(1);
        nums.Add(3);
        nums.Add(5);
        nums.Add(4);
        nums.Add(2);

        Console.WriteLine("До сортировки: ");
        for (int i = 0; i < nums.Count; i++)
        {
            Console.WriteLine(nums[i]);
        }


        Console.WriteLine();
        Console.WriteLine("После сортировки: ");
        nums.Sort();
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
        for (int i = 0; i < nums.Count; i++)
        {
            if (nums[i] == targget)
            {
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







        Console.WriteLine();
        Dictionary<string, int> ages = new Dictionary<string, int>
        {
            { "Юрий", 36 }, // { Ключ, значение }
            { "Фома", 52 },
            { "Тома", 19 }
        };

        string nameKey = "Юр"; 
        bool found = false;

        foreach (var pair in ages)
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
        */







        // Создать новый словарь с несколькими элементами. (Имя возрост)
        // Написать код, который выводит все ключи начинающиеся на букву 'Ю'.
        // Поиск имён: Юра, Юрей, Юля.
        /*
        Dictionary<string, int> keyValuePairs = new Dictionary<string, int>
        {
            { "Наталья", 15 },
            { "Юра", 15 },
            { "Юля", 15 },
            { "Ёрик", 15 },
            { "Юрей", 15 }
        };

        string nameKey = "Ю";
        // string nameKey = Console.ReadLine();
        bool found = false;

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








        // Создать список с цифрами.
        // Написать код, который выведет все места на которых замечена '1'.
        Console.WriteLine();
        List<int> nums = new List<int>{ 1, 5, 5, 3, 1, 2, 3, 1 };

        int target = 1;
        found = false;

        for (int i = 0; i < nums.Count; i++)
        {
            if (nums[i] == target)
            {
                Console.WriteLine($"Найдено число '1' на позициях '{i}'");
                found = true;
            }
        }
        */






        List<Car> Cars = new List<Car>();

        Car car = new Car();

        car.Marka = "Lada (ВАЗ)";
        car.Model = 21093;
        car.EntryYear = 2002;

        Cars.Add(car);

        car.Greet();

    }
}

class Car
{
    public string Marka { get; set; }
    public int Model { get; set; }
    public int EntryYear { get; set; }
    public void Greet()
    {
        Console.WriteLine($"Марка машины: {Marka}. Модель: {Model}. Год выпуска: {EntryYear}.");
    }
}