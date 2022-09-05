using System;

class Program
{



    static void Hello()
    {
        Console.WriteLine("Выберите задачу каторую будем решать: ");
        Console.WriteLine("1 - Задача 64: Задайте значения M и N. Напишите программу, которая выведет все натуральные числа в промежутке от M до N.");
        Console.WriteLine("2 - Задача 66: Задайте значения M и N. Напишите программу, которая найдёт сумму натуральных элементов в промежутке от M до N.");
        Console.WriteLine("3 - Задача 68: Напишите программу вычисления функции Аккермана с помощью рекурсии. Даны два неотрицательных числа m и n.");
        Console.WriteLine("4 - Выход");
    }

    // функция Аккермана
    static int Akkerman(int n, int m)
    {
        if (n == 0)
            return m + 1;
        else
          if ((n != 0) && (m == 0))
            return Akkerman(n - 1, 1);
        else
            return Akkerman(n - 1, Akkerman(n, m - 1));
    }

    static void Main()
    {
        while (true)
        {
            Hello();
            Console.Write("Ввведите цифру: "); // выбираем меню
            int MenuNumber = Convert.ToInt32(Console.ReadLine());



            if (MenuNumber == 1) // 
            {
                Console.Write("Ввведите m= "); int m = Convert.ToInt32(Console.ReadLine());
                Console.Write("Ввведите n= "); int n = Convert.ToInt32(Console.ReadLine());

                if (m <= n)
                {
                    while (m <= n)
                    {
                        Console.Write(m + " ");
                        m++;
                    }
                }
                else Console.WriteLine("Введены неверные значения");
                Console.WriteLine();
            }
            if (MenuNumber == 2) // 
            {
                Console.Write("Ввведите m= "); int m = Convert.ToInt32(Console.ReadLine());
                Console.Write("Ввведите n= "); int n = Convert.ToInt32(Console.ReadLine());
                int sum = 0;
                if (m <= n)
                {
                    while (m <= n)
                    {
                        sum += m;
                        m++;
                    }
                }
                else Console.WriteLine("Введены неверные значения");
                Console.WriteLine($"Сумма всех чисел: {sum}");
            }
            if (MenuNumber == 3) // 
            {
                Console.Write("Ввведите неотрицательное n= "); int n = Convert.ToInt32(Console.ReadLine());
                Console.Write("Ввведите неотрицательное m= "); int m = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine($"A({n},{m})= {Akkerman(n, m)}");
            }
            if (MenuNumber == 4)
            {
                break;
            }
        }
    }
}