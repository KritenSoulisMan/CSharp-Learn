using System;
using System.Diagnostics.CodeAnalysis;
using System.Globalization;

class First_Day
{
    static void Main()
    {
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
    }
}