using System;
using System.Diagnostics.CodeAnalysis;
using System.Globalization;

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
        int a int.Parse(Console.ReadLine());
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





        // Подготовка к практике:
        /*
        void PrintNumber()
        {
            Number = 9;
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
    }
}