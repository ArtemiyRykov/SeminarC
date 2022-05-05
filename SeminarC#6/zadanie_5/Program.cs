// Задача 45: Напишите программу, которая будет создавать копию заданного массива с помощью поэлементного 
// копирования.

Console.Write("Введите длину массива: ");
int Length = Convert.ToInt32(Console.ReadLine());
int[] array = new int[Length];

FillArray(array);
Console.Write("Новый массив:  ");
WriteArray(array);

int[] newArray = new int[Length];
for (int i = 0; i < newArray.Length; i++)
{
    newArray[i]= array[i];
}

Console.Write("Копия массива: ");
WriteArray(newArray);


void FillArray(int[] array) // функция заполнения массива
{
    for (int i = 0; i < array.Length; i++)
    {
        array[i] = new Random().Next(1, 100);
    }
}

void WriteArray(int[] array)// функция вывода массива
{
    for (int i = 0; i < array.Length; i++)
    {
        Console.Write(array[i] + " ");
    }
    Console.WriteLine();
}

