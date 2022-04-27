// 26. Напите программу которая выдают принимает на вход число и выдает кол-во цифр чисел
// 456->3,  78->2,  89126->5.

//1 способ
/*
Console.Write("Введите число: ");
string number = Convert.ToString(Console.ReadLine());

int result = 0;
for (int i = 0; i < number.Length; i++)
{
    result++;
}
Console.WriteLine($"Ответ: {result}");
*/

// способ 2
/*
Console.Write("Введите число: ");
string number = Convert.ToString(Console.ReadLine());
int sqr = number.Length;
Console.WriteLine($"Ответ: {sqr}");
*/

// 3 способ

Console.Write("Введите число: ");
int number = Convert.ToInt32(Console.ReadLine());

int index = 0;
while (number != 0)
{
    number = number / 10;

    index++;
}
Console.WriteLine($"Ответ: {index}");
