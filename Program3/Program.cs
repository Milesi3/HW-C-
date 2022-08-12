using System;

class Program
{
    static void Hello()
    {
        Console.WriteLine("Выберите задачу каторую будем решать: ");
        Console.WriteLine("1 - Задача 19: Вводим пятизначное, проверяем палиндром ли оно");
        Console.WriteLine("2 - Задача 21: Вводим координаты двух точек в 3D, находим расстояние между ними");
        Console.WriteLine("3 - Задача 23: Вводим число, и выводим таблицу кубов");
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
                int[] arra = new int[5];
                int number2 = Convert.ToInt32(Console.ReadLine());
                int flag = 0;
                int leng = arra.Length;
                
                while (number2 > 0)
                {
                    arra[leng-1] = number2 % 10;
                    number2 /= 10;
                    leng--;
                }
                for(int i=0; i<arra.Length; i++)
                {
                    if (arra[i] != arra[arra.Length - i -1])
                    {
                        flag=1;
                    }
                    
                }
                if (flag==1)
                {
                    Console.WriteLine("Нет");
                }
                else
                {
                    Console.WriteLine("Палиндром");
                }
            }
            if (number1 == 2) 
            {
                double[] arra1 = new double[3];
                double[] arra2 = new double[3];
                double sum = 0;

                Console.WriteLine("Введите первую точку");
                for (int i = 0; i < 3; i++)
                {
                    arra1[i] = Convert.ToDouble(Console.ReadLine());
                }
                Console.WriteLine("Введите вторую точку");
                for (int i = 0; i < 3; i++)
                {
                    arra2[i] = Convert.ToDouble(Console.ReadLine());
                }
                for (int i = 0; i < 3; i++)
                {
                    sum += Math.Pow(arra1[i] - arra2[i],2);
                }
                Console.WriteLine(Math.Sqrt(sum));
            }
            if (number1 == 3) 
            {
                Console.Write("Введите число: ");
                double number2 = Convert.ToDouble(Console.ReadLine());
                double number3 = 1;
                while (number3<=number2)
                {
                    Console.Write(Math.Pow(number3, 3)+ " ");
                    number3++;
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