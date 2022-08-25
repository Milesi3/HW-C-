using System;

class Program
{
    static void Hello()
    {
        Console.WriteLine("Выберите задачу каторую будем решать: ");
        Console.WriteLine("1 - Задача 41: Пользователь вводит с клавиатуры M чисел. Посчитайте, сколько чисел больше 0 ввёл пользователь.");
        Console.WriteLine("2 - Задача 43: Напишите программу, которая найдёт точку пересечения двух прямых, заданных уравнениями y = k1 * x + b1, y = k2 * x + b2; значения b1, k1, b2 и k2");
        Console.WriteLine("3 - Выход");
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
                Console.Write("Введите цифры через пробел: ");
                string num = Console.ReadLine();
                string[] array = num.Split(' ');
                int count = 0; 

                for (int i = 0; i < array.Length-1; i++)
                {
                    int a = Convert.ToInt32(array[i]);
                    if (a>0)
                    {
                        count++;
                    }
                }
                Console.WriteLine($"Ответ: {count}");

            }
            if (number1 == 2) 
            {
                Console.Write("Введите значения b1, k1, b2 и k2 : ");
                int[] array = new int[4];
                for (int i = 0; i < array.Length; i++)
                {
                    array[i]=Convert.ToInt32(Console.ReadLine()); //(b2 - b1)/(k1 - k2);
                }
                int x = (array[2] - array[0]) / (array[1] -array[3]);
                int y = array[1]*x + array[0];
                Console.WriteLine("x: " + x);Console.WriteLine("y: " + y);

            }
            if (number1 == 3)
            {
                break;
            }
        
        }
    }
}
