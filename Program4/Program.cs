using System;

class Program
{
    static void Hello()
    {
        Console.WriteLine("Выберите задачу каторую будем решать: ");
        Console.WriteLine("1 - Задача 25: Напишите цикл, который принимает на вход два числа (A и B) и возводит число A в натуральную степень B");
        Console.WriteLine("2 - Задача 27: Напишите программу, которая принимает на вход число и выдаёт сумму цифр в числе.");
        Console.WriteLine("3 - Задача 29: Напишите программу, которая задаёт массив из 8 элементов и выводит их на экран.");
        Console.WriteLine("4 - Выход");
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
                Console.WriteLine("Введите число: ");
                int a = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine("Введите степень: ");
                int b = Convert.ToInt32(Console.ReadLine());
                int c = a;
                while(0<b-1)
                {
                    a *= c; 
                    b--;
                }
                Console.WriteLine("Ваше число: " + a);

            }
            if (number1 == 2) 
            {
                Console.Write("Ввведите цифру: ");
                string number2 = Convert.ToString(Console.ReadLine());
                int leng = number2.Length;
                int number3 = Convert.ToInt32(number2);
                int[] arra = new int[leng];
                int sum = 0;
                
                while (number3 > 0)
                {
                    arra[leng-1] = number3 % 10;
                    sum += arra[leng-1];
                    number3 /= 10;
                    leng--;
                }
                Console.WriteLine("Ваша сумма чисел: " + sum);
            }
            if (number1 == 3) 
            {
                double[] array1 = new double[8];

                Console.WriteLine("Введите массив:");
                for (int i = 0; i < 8; i++)
                {
                    array1[i] = Convert.ToDouble(Console.ReadLine());
                }
                Console.Write("Ваш массив: ");
                for (int i = 0; i < 8; i++)
                {
                    Console.Write(array1[i] + " ");
                }
                Console.WriteLine(" ");
            }
            if (number1 == 4)
            {
                break;
            }
        }
    }
}
