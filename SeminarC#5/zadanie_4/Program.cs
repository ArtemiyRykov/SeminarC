// Задача 35: Задайте одномерный массив из 123 случайных чисел. Найдите количество элементов массива, значения которых лежат в 
// отрезке [10,99]. Пример для массива из 5, а не 123 элементов. В своём решении сделайте для 123.
// [5, 18, 123, 6, 2] -> 1
// [1, 2, 3, 6, 2] -> 0
// [10, 11, 12, 13, 14] -> 5

Console.Write("Введите количество элементов: ");
int numberMas = Convert.ToInt32(Console.ReadLine());

int[] numbers = new int[numberMas];

FillArray(numbers);
WriteArray(numbers);

int count = 0;
for (int i = 0; i < numbers.Length; i++)
{
    if (numbers[i] >= 10 && numbers[i] < 100)
        count++;
}
Console.WriteLine($"Количество элементов лежащих в массиве[10, 99] = {count}");



void FillArray(int[] array) //функция создание радомных чисел массива
{
    for (int i = 0; i < array.Length; i++)
    {
        array[i] = new Random().Next(1, 124);
    }
}

void WriteArray(int[] array)  // функция вывода массива
{
    for (int i = 0; i < array.Length; i++)
    {
        Console.Write(array[i] + " ");
    }
    Console.WriteLine();
}



