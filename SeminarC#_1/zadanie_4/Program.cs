﻿//4. Напишите программу, которая на вход принимает одно число (N), а на выходе показывает все целые числа в промежутке от -N до N.
// 2 -> " -2, -1, 0, 1, 2" , 4 -> "-4, -3, -2, -1, 0, 1, 2, 3, 4" 

Console.Write("Введите число: ");
int numberA = Convert.ToInt32(Console.ReadLine());

int numberB = -numberA;


while (numberB <= numberA)
{
    Console.Write(numberB + ", ");
    numberB++;
}

//УБрали Запятую
//while (numberB <= numberA)
//{
 //   Console.Write(numberB);
  //  numberB++;

 //   if (numberB <= numberA)
//    {
 //       Console.Write(", ");
 //   }
//}