/*12. Напишите программу, которая будет принимать на вход два числа и выводить, 
является ли второе число кратным первому. Если число 2 не кратно числу 1,
то программа выводит остаток от деления. Использовать фукции.
34, 5-> не кратное, остаток 4,   16, 4->кратное.*/


Console.Write("Введите первое число: ");
int numberA = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите второе число: ");
int numberB = Convert.ToInt32(Console.ReadLine());

/*
if(numberA % numberB == 0)
{
    Console.Write("Число кратное");
}
else
{
    Console.Write($"Число не кратное, остаток: {numberA % numberB}");
}*/

int ostatok = OstatokOT(numberA,numberB);
if(ostatok == 0)
{
    Console.Write("Число кратное");
}
else
{
    Console.Write($"Число не кратное, остаток: {ostatok}");
}

int OstatokOT(int number1, int number2)  // функция вычесления остатка от деления
{
    return number1 % number2;
}