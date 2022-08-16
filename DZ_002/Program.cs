﻿// Напишите программу, которая принимает на вход число и выдаёт сумму цифр в числе.

Console.Write("Введите число N: ");
int number = Convert.ToInt32(Console.ReadLine());

int SumNumber(int number)
{
    int counter = Convert.ToString(number).Length;
    int advance = 0;
    int result = 0;

    for (int i = 0; i < counter; i++)
    {
        advance = number - number % 10;
        result = result + (number - advance);
        number = number / 10;
    }
    return result;
}

int sumNumber = SumNumber(number);
Console.WriteLine($"Сумма цифр в числе: {sumNumber}");
