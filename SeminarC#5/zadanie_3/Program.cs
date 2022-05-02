// Задача 33: Задайте массив. Напишите программу, которая 
// определяет, присутствует ли заданное число в массиве.
// 4; массив [6, 7, 19, 345, 3] -> нет
// -3; массив [6, 7, 19, 345, 3] -> да


int[] numbers = new int[4];
for (int i = 0; i < numbers.Length; i++) // цикл для ввода чисел
{
    Console.Write($"Введите элемент массива {i + 1}: ");
    numbers[i] = Convert.ToInt32(Console.ReadLine());
}
WriteArray(numbers);

Console.Write("Ведите число для поиска в массиве: ");
int searchNumber = Convert.ToInt32(Console.ReadLine());

for (int i = 0; i < numbers.Length; i++)
{
    if (numbers[i] == searchNumber)
    {
        Console.WriteLine($"Число {searchNumber} находится в элементе массива {i} ");
        break;
    }
    else if(i == numbers.Length-1)
    {
        Console.WriteLine($"Число {searchNumber} НЕ находится массиве ");
        break;
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