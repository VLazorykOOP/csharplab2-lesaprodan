using System;

class Program
{
    static void Main()
    {
        // Введення кількості рядків східчастого масиву
        Console.Write("Введіть кількість рядків масиву (n): ");
        if (!int.TryParse(Console.ReadLine(), out int n) || n <= 0)
        {
            Console.WriteLine("Некоректне значення кількості рядків.");
            return;
        }

        // Створення східчастого масиву
        int[][] jaggedArray = new int[n][];
        
        // Заповнення східчастого масиву
        for (int i = 0; i < n; i++)
        {
            Console.Write($"Введіть кількість елементів у рядку {i + 1}: ");
            if (!int.TryParse(Console.ReadLine(), out int m) || m <= 0)
            {
                Console.WriteLine("Некоректне значення кількості елементів у рядку.");
                return;
            }

            jaggedArray[i] = new int[m];
            for (int j = 0; j < m; j++)
            {
                Console.Write($"Введіть елемент [{i + 1},{j + 1}]: ");
                if (!int.TryParse(Console.ReadLine(), out jaggedArray[i][j]))
                {
                    Console.WriteLine("Некоректне значення елемента масиву.");
                    return;
                }
            }
        }

        // Створення нового масиву для збереження останніх парних елементів
        int[] lastEvenElements = new int[n];
        for (int i = 0; i < n; i++)
        {
            lastEvenElements[i] = FindLastEvenElement(jaggedArray[i]);
        }

        // Виведення нового масиву
        Console.WriteLine("Масив останніх парних елементів у кожному рядку:");
        foreach (int element in lastEvenElements)
        {
            Console.Write(element + " ");
        }
    }

    static int FindLastEvenElement(int[] array)
    {
        for (int i = array.Length - 1; i >= 0; i--)
        {
            if (array[i] % 2 == 0)
            {
                return array[i];
            }
        }
        return -1; // Повертає -1, якщо парний елемент не знайдено
    }
}
