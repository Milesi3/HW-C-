using System;

class Program
{



    static void Hello()
    {
        Console.WriteLine("Выберите задачу каторую будем решать: ");
        Console.WriteLine("1 - Задача 10: Вводим трёхзанчное, показываем вторую цифру");
        Console.WriteLine("2 - Задача 13: Вводим трёхзанчное, показываем третью цифру");
        Console.WriteLine("3 - Задача 15: Проверка на выходной день");
        Console.WriteLine("4 - Выход");
    }


    static void Main()
    {
        while (true)
        {
            Hello();
            Console.Write("Ввведите цифру: "); // выбираем меню
            int number1 = Convert.ToInt32(Console.ReadLine());

            if (number1 == 1) //Вводим трёхзанчное, показываем вторую цифру
            {
                Console.Write("Ввведите цифру: ");
                number1 = Convert.ToInt32(Console.ReadLine());
                while (number1 > 99)
                {
                    number1 = number1 / 10;
                }
                if (number1 >= 10)
                {
                    Console.WriteLine("Вторая цифра числа: " + (number1 % 10));
                }
                else
                {
                    Console.WriteLine("Значение не верно");
                }
            }
            if (number1 == 2) // Вводим трёхзанчное, показываем третью цифру
            {
                Console.Write("Ввведите цифру: ");
                number1 = Convert.ToInt32(Console.ReadLine());
                while (number1 > 999)
                {
                    number1 = number1 / 10;
                }
                if (number1 >= 100)
                {
                    Console.WriteLine("Третья цифра числа: " + (number1 % 10));
                }
                else
                {
                    Console.WriteLine("Значение не верно");
                }
            }
            if (number1 == 3) // Проверка на выходной день
            {
                Console.Write("Ввведите цифру от 1 до 7: ");
                number1 = Convert.ToInt32(Console.ReadLine());
                if (number1 > 0 && number1 < 8)
                {
                    if (number1 >= 1 && number1 <= 5)
                    {
                        Console.WriteLine("Будний день");
                    }
                    else
                    {
                        Console.WriteLine("Выходной день");
                    }
                }
                else
                {
                    Console.WriteLine("Значение неверно :(");
                }
            }
            if (number1 == 4)
            {
                break;
            }
        }
    }
}





