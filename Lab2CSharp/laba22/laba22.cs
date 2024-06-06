using System;

class Program
{
    static void Main()
    {
        // Введення розмірності масиву з перевіркою на null та коректність вводу
        Console.Write("Введіть розмір масиву: ");
        if (!int.TryParse(Console.ReadLine(), out int size) || size <= 0)
        {
            Console.WriteLine("Некоректне значення розміру масиву.");
            return;
        }

        // Створення та заповнення масиву
        double[] array = new double[size];
        for (int i = 0; i < size; i++)
        {
            Console.Write($"Введіть елемент масиву [{i}]: ");
            if (!double.TryParse(Console.ReadLine(), out array[i]))
            {
                Console.WriteLine("Некоректне значення елемента масиву.");
                return;
            }
        }

        // Пошук останнього максимального елемента
        double maxElement = array[0];
        int lastIndex = 0;

        for (int i = 1; i < size; i++)
        {
            if (array[i] >= maxElement)
            {
                maxElement = array[i];
                lastIndex = i;
            }
        }

        // Виведення результату
        Console.WriteLine($"Номер останнього максимального елемента: {lastIndex}");
    }
}
