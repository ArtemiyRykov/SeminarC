// Задача 32: Напишите программу замена элементов 
// массива: положительные элементы замените на 
// соответствующие отрицательные, и наоборот.
// [-4, -8, 8, 2] -> [4, 8, -8, -2] 


int[] numbers = new int[4];
for (int i = 0; i < numbers.Length; i++) // цикл для ввода чисел
{
    Console.Write($"Введите элемент массива {i + 1}: ");
    numbers[i] = Convert.ToInt32(Console.ReadLine());
}

WriteArray(numbers);

for (int i = 0; i < numbers.Length; i++) numbers[i] *= -1;

WriteArray(numbers);





void WriteArray(int[] array)  // функция вывода массива
{
    for (int i = 0; i < array.Length; i++)
    {
        Console.Write(array[i] + " ");
    }
    Console.WriteLine();
}