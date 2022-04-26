/*11. Напишите программу которая выводит случайное трехзначное число и удаляет вторую цифру этого числа.
Нужно использовать хотя бы одну функцию.
456->46, 782->72, 918->98.*/

// 1. Способ
/*int number = RandomInt(100,1000);
Console.WriteLine($"Трех значное число: {number}");
int number1 = number / 100;
int number2 = number % 10;
int result = number1 * 10 + number2;

Console.WriteLine($"Трех значное число: {number}");
Console.WriteLine($"Первая цифра: {number1}");
Console.WriteLine($"Третья цифра: {number2}");
Console.WriteLine($"Вывод числа без второй цифры: {result}");*/


// 2. Способ
/*int number = RandomInt(100,1000);
Console.WriteLine($"Трех значное число: {number}");
int result = ResultInt(number);
Console.WriteLine($"Вывод числа без второй цифры: {result}");

int ResultInt(int arg) // функция вычисления
{
    int first = arg / 100;
    int second = arg % 10;
    return first * 10 + second;
}
int RandomInt(int min, int max) // Функция рандома
{
    return new Random().Next(min, max);
}*/

//Console.WriteLine(Convert.ToString(number1) + Convert.ToString(nomber2)) // - Склейка двух чисел построчно

// 3. Способ
int number = RandomInt(100,1000);
Console.WriteLine($"Трех значное число: {number}");
string stringNumber = Convert.ToString(number); // конвертировали int в string
Console.WriteLine($"{stringNumber[0]}{stringNumber[2]}"); // в string как массив обозначение переменных



int RandomInt(int min, int max) // Функция рандома
{
    return new Random().Next(min, max);
}
