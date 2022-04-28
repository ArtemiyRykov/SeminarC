// 28. Напишите программу, которая принимает на вход число от 1 до number
// 4->24, 5->120.


// while Способ 1
/*
Console.Write("Введите число: ");
int number = Convert.ToInt32(Console.ReadLine());

int index = 1;
int faсt = 1;
while (index <= number)
{
    faсt = index * faсt;
    index++;
}
Console.Write("Ответ: " + faсt);
*/

//for способ 1

Console.Write("Введите число: ");
int number = Convert.ToInt32(Console.ReadLine());

int faсt = 1;
for (int i = 1; i <= number; i++) faсt = i * faсt;

Console.Write("Ответ: " + faсt);