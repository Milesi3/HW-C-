using System;

class Program
{



    static void Hello()
    {
        Console.WriteLine("Выберите задачу каторую будем решать: ");
        Console.WriteLine("1 - Задача 47. Задайте двумерный массив размером m×n, заполненный случайными вещественными числами.");
        Console.WriteLine("2 - Задача 50. Напишите программу, которая на вход принимает позиции элемента в двумерном массиве, и возвращает значение этого элемента или же указание, что такого элемента нет.");
        Console.WriteLine("3 - Задача 52. Задайте двумерный массив из целых чисел. Найдите среднее арифметическое элементов в каждом столбце.");
        Console.WriteLine("4 - Выход");
    }
    // static int[] CreaterRandomArray(int m, int n)
    // {
    //     int[,] array = new int[m, n];
    //     for (int i = 0; i < array.GetLength(0); i++)
    //     {
    //         for (int j = 0; j < array.GetLength(1); j++)
    //         {
    //             array[i, j] = new Random().Next(0, 10);  
    //             Console.Write(array[i, j] + " ");
    //         }
    //         Console.WriteLine();
    //     }
    //     return array; Выдал ошибку: Не удается неявно преобразовать тип "int[*,*]" в "int[]"
    // }


    static void Main()
    {
        while (true)
        {
            Hello();
            Console.Write("Ввведите цифру: "); // выбираем меню
            int MenuNumber = Convert.ToInt32(Console.ReadLine());



            if (MenuNumber == 1) // Задача 47. Задайте двумерный массив размером m×n, заполненный случайными вещественными числами.
            {
                Console.Write("Ввведите m= "); int m = Convert.ToInt32(Console.ReadLine());

                Console.Write("Ввведите n= "); int n = Convert.ToInt32(Console.ReadLine());

                int[,] array = new int[m, n];
                for (int i = 0; i < array.GetLength(0); i++)
                {
                    for (int j = 0; j < array.GetLength(1); j++)
                    {
                        array[i, j] = new Random().Next(0, 10);
                        Console.Write(array[i, j] + " ");
                    }
                    Console.WriteLine();
                }
            }
            if (MenuNumber == 2) // Задача 50. Напишите программу, которая на вход принимает позиции элемента в двумерном массиве, и возвращает значение этого элемента или же указание, что такого элемента нет.
            {
                string[,] array = {{"22","3","4"},
                                   {"8","6","5"},
                                   {"3","2","1"},
                                   {"5","4","2"},
                                   {"2","1","9"}};
                Console.Write("Ввведите номер сторки "); int Line = Convert.ToInt32(Console.ReadLine());
                Console.Write("Ввведите номер стобца "); int Column = Convert.ToInt32(Console.ReadLine());

                if (array.GetLength(0) >= Line && array.GetLength(1) >= Column) { System.Console.WriteLine($"Ответ: {array[Line, Column]}"); }
                else { System.Console.WriteLine("Ответ: Неврное значение"); }
            }
            if (MenuNumber == 3) // Задача 52. Задайте двумерный массив из целых чисел. Найдите среднее арифметическое элементов в каждом столбце.
            {
                int[,] array = {{1,3,4},
                                {8,6,5},
                                {3,2,1},
                                {5,5,5},
                                {2,1,9}};
                double average = 0;
                for (int i = 0; i < array.GetLength(0); i++)
                {
                    for (int j = 0; j < array.GetLength(1); j++)
                    {
                        Console.Write(array[i, j] + " ");
                        average += array[i, j];
                    }
                    Console.Write($" Среднее арифметическое строки: {Math.Round(average / array.GetLength(1), 1)}");
                    average = 0;
                    Console.WriteLine();
                }
            }
            if (MenuNumber == 4)
            {
                break;
            }
        }
    }
}