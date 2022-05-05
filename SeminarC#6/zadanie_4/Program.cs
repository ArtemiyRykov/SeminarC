// Задача 44: Не используя рекурсию, выведите первые N чисел Фибоначчи. Первые два числа Фибоначчи: 0 и 1.
// Если N = 5 -> 0 1 1 2 3
// Если N = 3 -> 0 1 1
// Если N = 7 -> 0 1 1 2 3 5 8


Console.Write("Введите число: ");
int number = Convert.ToInt32(Console.ReadLine());
int[] Fibonacci = new int[number];

for (int i = 0; i < Fibonacci.Length; i++)
{
    if (i == 0)
        Fibonacci[i] = 0;
    else if (i == 1)
        Fibonacci[i] = 1;
    else
        Fibonacci[i] = Fibonacci[i - 1] + Fibonacci[i - 2];
}

WriteArray(Fibonacci);

void WriteArray(int[] array)// функция вывода массива
{
    for (int i = 0; i < array.Length; i++)
    {
        Console.Write(array[i] + " ");
    }
    Console.WriteLine();
}
