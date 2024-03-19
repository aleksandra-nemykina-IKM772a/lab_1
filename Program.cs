/*Транспонування двовимірного масиву:


namespace MatrixTranspose
{
    class Program
    {
        static void Main(string[] args)
        {
           
            int[,] originalMatrix = {
                { 1, 2, 3 },
                { 4, 5, 6 },
                { 7, 8, 9 }
            };

           
            int rows = originalMatrix.GetLength(0);
            int cols = originalMatrix.GetLength(1);

           
            int[,] transposedMatrix = new int[cols, rows];

           
            for (int i = 0; i < rows; i++)
            {
                for (int j = 0; j < cols; j++)
                {
                    transposedMatrix[j, i] = originalMatrix[i, j];
                }
            }

           
            Console.WriteLine("Транспонована матриця:");
            for (int i = 0; i < cols; i++)
            {
                for (int j = 0; j < rows; j++)
                {
                    Console.Write(transposedMatrix[i, j] + " ");
                }
                Console.WriteLine();
            }
        }
    }
}
/*

/*Конвертація температури з градусів Цельсія в градуси Фаренгейта:


using System.Text;

namespace TemperatureConverter
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Введіть температуру по Цельсію (°C): ");
            double celsius = double.Parse(Console.ReadLine());

            // Формула для перетворення градусів Цельсія в градуси Фаренгейта
            double fahrenheit = (celsius * 9) / 5 + 32;

            Console.WriteLine($"Температура у градусах Фаренгейта: {fahrenheit} °F");
        }
    }
}
 */

/*Знаходження мінімального і максимального елементів у масиві
    using System;

namespace MinMaxArray
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] array = { 8, 3, 5, -1, 2 };

            int min = array[0];
            int max = array[0];

            foreach (int num in array)
            {
                if (num < min)
                    min = num;
                if (num > max)
                    max = num;
            }

            Console.WriteLine($"Мінімальний елемент: {min}");
            Console.WriteLine($"Максимальний елемент: {max}");
        }
    }
}
*/


//Генерація випадкового пароля:
using System;

class Program
{
    static void Main(string[] args)
    {
        Console.Write("Введіть довжину паролю: ");
        int length = int.Parse(Console.ReadLine());
        Console.WriteLine($"Випадковий пароль: {GeneratePassword(length)}");
    }

    static string GeneratePassword(int length)
    {
        const string lowerCase = "abcdefghijklmnopqrstuvwxyz";
        const string upperCase = "ABCDEFGHIJKLMNOPQRSTUVWXYZ";
        const string digits = "0123456789";
        const string specialCharacters = "!@#$%^&*()_-+=[]{}|;:<>,.?/";
        string allCharacters = lowerCase + upperCase + digits + specialCharacters;
        Random random = new Random();
        char[] password = new char[length];

        for (int i = 0; i < length; i++)
        {
            password[i] = allCharacters[random.Next(allCharacters.Length)];
        }

        return new string(password);
    }
}

