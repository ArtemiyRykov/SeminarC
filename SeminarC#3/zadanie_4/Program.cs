// 22. Напишите программу, которая принимает на вход число (N) и выдает таблицу квадратовчисел от 1 до N.
// 5->1,4,9,16,25 .   2->1,4


Console.Write("Введите число: ");
double number = Convert.ToDouble(Console.ReadLine());
double index = 1;

while (index <= number)
{
    double square = Math.Pow(index, 2);
    index++;
    Console.Write($"{square}, ");
}
