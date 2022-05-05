// Задача 42: Напишите программу, которая будет преобразовывать десятичное число в двоичное.
// 45 -> 101101
// 3 -> 11
// 2 -> 10

/*
Console.Write("Введите число: ");
int number = Convert.ToInt32(Console.ReadLine());

string result = "" + number % 2;
while (number >= 2)
{
    number = number/2;
    int remains = number%2;
    result = remains + result; 
}
Console.WriteLine(result);
*/

int number = 19;
int binSize = 0;

int tempNumber = number;
while (tempNumber != 0)
{
    tempNumber /= 2;
    binSize++;
}

int[] binArray = new int[binSize];
tempNumber = number;
for(int i = binArray.Length - 1; i>=0; i--)
{
    binArray[i] = tempNumber % 2;
    tempNumber/=2;
}

WriteArray(binArray);

void WriteArray(int[] array)// функция вывода массива
{
    for (int i = 0; i < array.Length; i++)
    {
        Console.Write(array[i] + " ");
    }
    Console.WriteLine();
}











