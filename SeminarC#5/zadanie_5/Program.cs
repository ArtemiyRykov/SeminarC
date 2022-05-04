// Задача 37: Найдите произведение пар чисел в одномерном массиве. Парой считаем первый и 
// последний элемент, второй и предпоследний и т.д. Результат запишите в новом массиве.
// [1 2 3 4 5] -> 5 8 3
// [6 7 3 6] -> 36 21

Console.Write("Введите размер массива: ");
int Length = Convert.ToInt32(Console.ReadLine());
int[] numbers = new int[Length];

FillArray(numbers);
WriteArray(numbers);

int newLength;   
if (Length % 2 == 0)  //// делем массив пополам и остается ли остаток при делени
{
    newLength = Length / 2; // если остатка нет
}
else
{
    newLength = Length / 2 + 1; /// остаток есть
}

int[] numbersSumm = new int[newLength];   /// создаем новый массив куда будем складывать суммы
for (int i = 0; i < numbersSumm.Length; i++)
{
    numbersSumm[i] = numbers[i] * numbers[numbers.Length - 1 - i]; // уножаем числа из масива и кладем в новый
}
if(Length % 2 !=0) // 
{
    numbersSumm[numbersSumm.Length-1] = numbers[numbersSumm.Length-1]; /// переносим в масив число которое остается одно в центре массива 
}
WriteArray(numbersSumm);



void FillArray(int[] array)
{
    for (int i = 0; i < array.Length; i++)
    {
        array[i] = new Random().Next(1, 10);
    }
}

void WriteArray(int[] array)
{
    for (int i = 0; i < array.Length; i++)
    {
        Console.Write(array[i] + " ");
    }
    Console.WriteLine();
}
