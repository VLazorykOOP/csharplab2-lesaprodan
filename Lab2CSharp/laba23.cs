using System;

class Program
{
    static void Main()
    {
        // Введення розмірності масиву з перевіркою на коректність вводу
        Console.Write("Введіть розмір масиву (n): ");
        if (!int.TryParse(Console.ReadLine(), out int n) || n <= 0)
        {
            Console.WriteLine("Некоректне значення розміру масиву.");
            return;
        }

        // Створення та заповнення масиву
        int[,] array = new int[n, n];
        for (int i = 0; i < n; i++)
        {
            for (int j = 0; j < n; j++)
            {
                Console.Write($"Введіть елемент масиву [{i},{j}]: ");
                if (!int.TryParse(Console.ReadLine(), out array[i, j]))
                {
                    Console.WriteLine("Некоректне значення елемента масиву.");
                    return;
                }
            }
        }

        // Виведення початкового масиву
        Console.WriteLine("Початковий масив:");
        PrintArray(array, n);

        // Обмін стовпців
        if (n % 2 == 0)
        {
            // Кількість стовпців парна - обмін двох середніх стовпців
            int middle1 = n / 2 - 1;
            int middle2 = n / 2;
            SwapColumns(array, n, middle1, middle2);
        }
        else
        {
            // Кількість стовпців непарна - обмін першого з середнім стовпцем
            int middle = n / 2;
            SwapColumns(array, n, 0, middle);
        }

        // Виведення зміненого масиву
        Console.WriteLine("Змінений масив:");
        PrintArray(array, n);
    }

    static void SwapColumns(int[,] array, int size, int col1, int col2)
    {
        for (int i = 0; i < size; i++)
        {
            int temp = array[i, col1];
            array[i, col1] = array[i, col2];
            array[i, col2] = temp;
        }
    }

    static void PrintArray(int[,] array, int size)
    {
        for (int i = 0; i < size; i++)
        {
            for (int j = 0; j < size; j++)
            {
                Console.Write(array[i, j] + " ");
            }
            Console.WriteLine();
        }
    }
}
