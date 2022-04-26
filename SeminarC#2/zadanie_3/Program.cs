/*11. Напишите программу которая выводит случайное трехзначное число и удаляет вторую цифру этого числа.
Нужно использовать хотя бы одну функцию.
456->46, 782->72, 918->98.*/

int number = RandomInt(100,1000);
Console.WriteLine($"Трех значное число: {number}");
/*int number1 = number / 100;
int number2 = number % 10;
int result = number1 * 10 + number2;

Console.WriteLine($"Трех значное число: {number}");
Console.WriteLine($"Первая цифра: {number1}");
Console.WriteLine($"Третья цифра: {number2}");
Console.WriteLine($"Вывод числа без второй цифры: {result}");*/

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
}

//Console.WriteLine(Convert.ToString(number1) + Convert.ToString(nomber2)) // - Склейка двух чисел построчно