// 26. Напите программу которая выдают принимает на вход число и выдает кол-во цифр чисел
// 456->3,  78->2,  89126->5.

Console.Write("Введите число: ");
string number = Convert.ToString(Console.ReadLine());

int result = 0;
for (int i = 0; i < number.Length; i++)
{
    result++;
}
Console.WriteLine($"Ответ: {result}");


// способ 2
/*
Console.Write("Введите число: ");
string number = Convert.ToString(Console.ReadLine());
int sqr = number.Length;
Console.WriteLine($"Ответ: {sqr}");
*/