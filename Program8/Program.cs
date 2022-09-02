using System;

class Program
{
    static void Hello()
    {
        Console.WriteLine("Выберите задачу каторую будем решать: ");
        Console.WriteLine("1 - Задача 54: Задайте двумерный массив. Напишите программу, которая упорядочит по убыванию элементы каждой строки двумерного массива.");
        Console.WriteLine("2 - Задача 56: Задайте прямоугольный двумерный массив. Напишите программу, которая будет находить строку с наименьшей суммой элементов.");
        Console.WriteLine("3 - Задача 58: Задайте две матрицы. Напишите программу, которая будет находить произведение двух матриц.");
        Console.WriteLine("4 - Задача 60. Сформируйте трёхмерный массив из неповторяющихся двузначных чисел. Напишите программу, которая будет построчно выводить массив, добавляя индексы каждого элемента.");
        Console.WriteLine("5 - Напишите программу, которая заполнит спирально массив 4 на 4.");
        Console.WriteLine("6 - Выход");
    }
    static void Swap(ref int FirstArg, ref int SecondArg)
    {
        int temp = FirstArg;
        FirstArg = SecondArg;
        SecondArg = temp;
    }
    static void Main()
    {
        while (true)
        {
            Hello();
            Console.Write("Ввведите цифру: "); // выбираем меню
            int number1 = Convert.ToInt32(Console.ReadLine());

            if (number1 == 1)
            {
                Random rnd = new Random();
                int[,] array = new int[4, 4];
                for (int i = 0; i < array.GetLength(0); i++)
                {
                    for (int j = 0; j < array.GetLength(1); j++)
                    {
                        array[i, j] = rnd.Next(0, 10);
                        Console.Write(array[i, j] + " ");

                    }
                    for (int p = 0; p < array.GetLength(0); p++)
                    {
                        for (int j = 0; j < array.GetLength(1) - 1 - p; j++)
                        {
                            if (array[i, j] < array[i, j + 1])
                            {
                                Swap(ref array[i, j], ref array[i, j + 1]);
                            }
                        }
                    }
                    Console.WriteLine();
                }
                Console.WriteLine();
                for (int i = 0; i < array.GetLength(0); i++)
                {
                    for (int j = 0; j < array.GetLength(1); j++)
                    {
                        Console.Write(array[i, j] + " ");
                    }
                    Console.WriteLine();
                }

            }

            if (number1 == 2)
            {
                Random rnd = new Random();
                int[,] array = new int[4, 5];
                int sum = 0;
                int min = 100;
                int mini = 0;
                for (int i = 0; i < array.GetLength(0); i++)
                {
                    sum = 0;
                    for (int j = 0; j < array.GetLength(1); j++)
                    {
                        array[i, j] = rnd.Next(0, 10);
                        Console.Write(array[i, j] + " ");
                        sum += array[i, j];
                    }
                    if (min > sum)
                    {
                        min = sum;
                        mini = i;
                    }
                    Console.WriteLine();
                }
                Console.WriteLine($"{mini + 1} Строка");
            }

            if (number1 == 3)
            {
                Random rnd = new Random();
                int[,] array1 = new int[2, 2];
                int[,] array2 = new int[2, 2];
                for (int i = 0; i < array1.GetLength(0); i++)
                {
                    for (int j = 0; j < array1.GetLength(1); j++)
                    {
                        array1[i, j] = rnd.Next(0, 10);
                        Console.Write(array1[i, j] + " ");
                    }
                    Console.WriteLine();
                }
                Console.WriteLine();

                for (int i = 0; i < array2.GetLength(0); i++)
                {
                    for (int j = 0; j < array2.GetLength(1); j++)
                    {
                        array2[i, j] = rnd.Next(0, 10);
                        Console.Write(array2[i, j] + " ");
                    }
                    Console.WriteLine();
                }
                Console.WriteLine();

                for (int i = 0; i < array2.GetLength(0); i++)
                {
                    for (int j = 0; j < array2.GetLength(1); j++)
                    {
                        array1[i, j] = array1[i, j] * array2[i, j];
                        Console.Write(array1[i, j] + " ");
                    }
                    Console.WriteLine();
                }
            }

            if (number1 == 4)
            {
                int[,,] array = new int[2, 2, 2];
                int n = 0;
                for (int i = 0; i < array.GetLength(0); i++)
                {
                    for (int j = 0; j < array.GetLength(1); j++)
                    {
                        for (int k = 0; k < array.GetLength(2); k++)
                        {
                            array[i, j, k] = n++;
                            Console.Write($"{array[i, j, k]}({i},{j},{k}) ");
                        }
                        Console.WriteLine();
                    }
                    Console.WriteLine();
                }
            }

            if (number1 == 5)
            {
                // вообще не понял как это делать 

            }

        if (number1 == 6) // выход
        {
            break;
        }
    }
}
}