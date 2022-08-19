using System;

class Program
{
    static void Hello()
    {
        Console.WriteLine("Выберите задачу каторую будем решать: ");
        Console.WriteLine("1 - Задача 1 -- показывал на семинаре");
        Console.WriteLine("2 - Задача 2 -- показывал на семинаре");
        Console.WriteLine("3 - Задача 34: Задайте массив заполненный случайными положительными трёхзначными числами. Напишите программу, которая покажет количество чётных");
        Console.WriteLine("4 - Задача 36: Задайте одномерный массив, заполненный случайными числами. Найдите сумму элементов, стоящих на нечётных позициях.");
        Console.WriteLine("5 - Задача 38: Задайте массив вещественных чисел. Найдите разницу между максимальным и минимальным элементов массива.");
        Console.WriteLine("6 - Выход");
    }
    static void Main()
    {
        while (true)
        {
            Hello();
            Console.Write("Ввведите цифру: "); // выбираем меню
            int number1 = Convert.ToInt32(Console.ReadLine());

            if (number1 == 1) // Задача 1
            {
                Random random = new Random();
                int b = 0;
                int[] array = new int[123];
                Console.Write("Массив: [");
                for (int i = 0; i < array.Length; i++)
                {
                    array[i] = random.Next(0, 100);
                    if (array[i] >= 10 && array[i] <= 99)
                    {
                        b++;
                    }
                    Console.Write(array[i] + " ");
                }
                Console.Write("] --> " + b);
                Console.WriteLine(" ");

            }
            
            if (number1 == 2) // Задача 2
            {
                Random random = new Random();
                int[] array1 = new int[12];
                int[] array2 = new int[6];
                Console.Write("Массив: [");
                for (int i = 0; i < array1.Length; i++)
                {
                    array1[i] = random.Next(0, 100);
                    Console.Write(array1[i] + " ");
                }
                Console.Write("] --> ");
                
                for (int i = 0; i < array2.Length; i++)
                {
                    array2[i] = array1[i] + array1[array1.Length-i-1];
                    Console.Write(array2[i] + " ");
                }
                Console.WriteLine(" ");

            }

            if (number1 == 3) // Задача 34
            {
                Random random = new Random();
                int b = 0;
                int[] array = new int[5];
                Console.Write("Массив: [");
                for (int i = 0; i < array.Length; i++)
                {
                    array[i] = random.Next(100, 999);
                    if (array[i] % 2 == 0)
                    {
                        b++;
                    }
                    Console.Write(array[i] + " ");
                }
                Console.Write("] --> " + b);
                Console.WriteLine(" ");
            }

            if (number1 == 4) // Задача 36
            {
                Random random = new Random();
                int b = 0;
                int[] array = new int[5];
                Console.Write("Массив: [");
                for (int i = 0; i < array.Length; i++)
                {
                    array[i] = random.Next(0, 100);
                    if (i % 2 != 0) // тут если брать отчет с 0 как и идет в массиве, то работает правильно
                    {
                        b+= array[i];
                    }
                    Console.Write(array[i] + " ");
                }
                Console.Write("] --> " + b);
                Console.WriteLine(" ");
            }

            if (number1 == 5) //Задача 38
            {
                Random random = new Random();
                int[] array = new int[5];
                int max = array[0];
                int min = 1000; // костыль, но рабочий)
                Console.Write("Массив: [");
                for (int i = 0; i < array.Length; i++)
                {
                    array[i] = random.Next(0, 100);
                    if (array[i] > max) 
                    {
                        max = array[i];
                    }
                    else if (array[i] < min) 
                    {
                        min = array[i];
                    }
                    Console.Write(array[i] + " ");
                }
                Console.Write("] --> " + (max-min));
                Console.WriteLine(" ");
            }

            if (number1 == 6) // выход
            {
                break;
            }
        }
    }
}
