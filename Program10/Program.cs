using System;

Console.Write("Введите через пробел: ");
string temp = Console.ReadLine();
string[] array = temp.Split(' ');
for (int i = 0; i < array.Length; i++)
{
    if (array[i].Length <= 3)
    {
        Console.Write(array[i] + " "); 
    }
}
    