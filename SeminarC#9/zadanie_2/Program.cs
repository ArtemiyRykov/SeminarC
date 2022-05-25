// Задача 65: Задайте значения M и N. Напишите программу, которая выведет все натуральные числа в промежутке от M до N.
// M = 1; N = 5 -> "1, 2, 3, 4, 5"
// M = 4; N = 8 -> "4, 6, 7, 8"*/

Console.WriteLine("Задайте число M: ");
int m = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Задайте число N: ");
int n = Convert.ToInt32(Console.ReadLine());

Console.Write(Rekurs(m,n));

int Rekurs(int numStart, int numEnd)
{
    if(numEnd == numStart)
    {
        return numEnd;
    }
    Console.Write(Rekurs(numStart,numEnd - 1) + ", ");
    return numEnd;
}

