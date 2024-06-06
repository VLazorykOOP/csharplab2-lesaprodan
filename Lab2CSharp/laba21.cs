using System;

class laba21
{
    static void Main()
    {
        // Вибір типу масиву
        Console.WriteLine("Оберіть тип масиву:");
        Console.WriteLine("1 - Одновимірний масив");
        Console.WriteLine("2 - Двовимірний масив");
        int choice = int.Parse(Console.ReadLine());

        if (choice == 1)
        {
            HandleOneDimensionalArray();
        }
        else if (choice == 2)
        {
            HandleTwoDimensionalArray();
        }
        else
        {
            Console.WriteLine("Невірний вибір!");
        }
    }

    static void HandleOneDimensionalArray()
    {
        // Введення розмірності масиву
        Console.Write("Введіть розмір масиву: ");
        int size = int.Parse(Console.ReadLine());

        // Створення та заповнення масиву
        int[] array = new int[size];
        for (int i = 0; i < size; i++)
        {
            Console.Write($"Введіть елемент масиву [{i}]: ");
            array[i] = int.Parse(Console.ReadLine());
        }

        // Підрахунок кількості непарних елементів
        int oddCount = 0;
        for (int i = 0; i < size; i++)
        {
            if (array[i] % 2 != 0)
            {
                oddCount++;
            }
        }

        // Виведення результату
        Console.WriteLine($"Кількість непарних елементів: {oddCount}");
    }

    static void HandleTwoDimensionalArray()
    {
        // Введення розмірності масиву
        Console.Write("Введіть кількість рядків масиву: ");
        int rows = int.Parse(Console.ReadLine());
        Console.Write("Введіть кількість стовпців масиву: ");
        int columns = int.Parse(Console.ReadLine());

        // Створення та заповнення масиву
        int[,] array = new int[rows, columns];
        for (int i = 0; i < rows; i++)
        {
            for (int j = 0; j < columns; j++)
            {
                Console.Write($"Введіть елемент масиву [{i},{j}]: ");
                array[i, j] = int.Parse(Console.ReadLine());
            }
        }

        // Підрахунок кількості непарних елементів
        int oddCount = 0;
        for (int i = 0; i < rows; i++)
        {
            for (int j = 0; j < columns; j++)
            {
                if (array[i, j] % 2 != 0)
                {
                    oddCount++;
                }
            }
        }

        // Виведення результату
        Console.WriteLine($"Кількість непарних елементів: {oddCount}");
    }
}
