using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharp_Learn.Scripts.TaskesList
{
    class Task_Animal_FileReader
    {

    }
    // 1. Базовый класс Animal
    class Animal
    {
        public virtual void Speak()
        {
            Console.WriteLine("Animal makes a sound");
        }
    }

    // 2. Производный класс Dog, который наследуется от Animal
    class Dog : Animal
    {
        public override void Speak()
        {
            Console.WriteLine("Dog barks");
        }
    }

    // 3. Производный класс Cat, который наследуется от Animal
    class Cat : Animal
    {
        public override void Speak()
        {
            Console.WriteLine("Cat meows");
        }
    }

    class Bird : Animal // Создан новый класс Bird
    {
        public override void Speak()
        {
            Console.WriteLine("Bird Chik-Chirik");
        }
    }

    class Program1
    {
        static async Task Main()
        {
            // 4. Используем полиморфизм
            Animal myAnimal = new Dog();
            myAnimal.Speak();  // Выведет: Dog barks

            myAnimal = new Cat();
            myAnimal.Speak();  // Выведет: Cat meows

            myAnimal = new Bird();
            myAnimal.Speak();  // Выведет: Bird Chik-Chirik

            // 5. Работа с файлами и обработка исключений
            string filePath = "animals.txt";

            try
            {
                await WriteToFileAsync(filePath);
                string content = await ReadFromFileAsync(filePath);
                Console.WriteLine("File content:");
                Console.WriteLine(content);
            }
            catch (Exception ex)
            {
                Console.WriteLine("An error occurred: " + ex.Message);
            }
        }

        // Асинхронный метод для записи данных в файл
        static async Task WriteToFileAsync(string path)
        {
            await using (StreamWriter writer = new StreamWriter(path))
            {
                await writer.WriteLineAsync("Dog barks");
                await writer.WriteLineAsync("Cat meows");
                await writer.WriteLineAsync("Bird Chik-Chirik");
            }
        }

        // Асинхронный метод для чтения данных из файла
        static async Task<string> ReadFromFileAsync(string path)
        {
            using (StreamReader reader = new StreamReader(path))
            {
                return await reader.ReadToEndAsync();
            }
        }
    }
}
