// Задача 39: Напишите программу, которая перевернёт одномерный массив (последний элемент будет на первом 
// месте, а первый - на последнем и т.д.)
// [1 2 3 4 5] -> [5 4 3 2 1]
// [6 7 3 6] -> [6 3 7 6]

int[] array = GetArray(6);
WriteArray(array);

for (int i = 0; i < array.Length / 2; i++)
{
    int temp = array[i];
    array[i] = array[array.Length - 1 - i];
    array[array.Length - 1 - i] = temp;
}
WriteArray(array);





int[] GetArray(int length) ///Метод создания массива
{
    int[] newArray = new int[length];
    FillArray(newArray);
    return newArray;
}

void FillArray(int[] array) // функция заполнения массива
{
    for (int i = 0; i < array.Length; i++)
    {
        array[i] = new Random().Next(1, 10);
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