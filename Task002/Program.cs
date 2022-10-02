﻿/*Задача 27: Напишите программу, которая принимает на вход число и выдаёт сумму цифр в числе.

452 -> 11

82 -> 10

9012 -> 12

Ограничения:
- Должна быть отдельная функция, которая возвразает результат суммы цифр
- Внутри функций НЕЛЬЗЯ использовать класс Console. Только в основном блоке кода
*/


Console.Write("Введите число: ");
int numberN = Convert.ToInt32(Console.ReadLine());


int SumNumber(int numberN)
{
    
  int counter = Convert.ToString(numberN).Length;
  int advance = 0;
  int result = 0;
  for (int i = 0; i < counter; i++)
  {
    advance = numberN - numberN % 10;
    result = result + (numberN - advance);
    numberN = numberN / 10;
  }
  return result;
}

int result = SumNumber(numberN);
Console.WriteLine($"Сумма цифр в числе: {result}");
