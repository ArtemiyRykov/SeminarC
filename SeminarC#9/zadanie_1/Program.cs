// Задача 63: Задайте значени N. Напишите программу, которая 
// выведет все натуральный числа в промежутки от 1 до N.
// Решить с помощью рекурсии.

Console.WriteLine("Задайте число N: ");
int n = Convert.ToInt32(Console.ReadLine());

int result = Rekurs(n);
Console.Write(result);

int Rekurs(int number)
{
    if(number == 1)
    {
        return 1;
    }
    int temp = Rekurs(number - 1);
    Console.Write(temp + ", ");
    return number;
}