// Задача 57: Составить частотный словарь элементов двумерного массива. Частотный словарь содержит 
// информацию о том, сколько раз встречается элемент входных данных.
// { 1, 9, 9, 0, 2, 8, 0, 9 }
// 0 встречается 2 раза 
// 1, 2, 3 
// 4, 6, 1 
// 2, 1, 6
// 1 встречается 3 раза 
// 2 встречается 2 раз 
// 3 встречается 1 раз 
// 4 встречается 1 раз 
// 6 встречается 2 раза

int m = Input("Введите m: ");
int n = Input("Введите n: ");
ArrayCreation(m, n);
FrequencyCheck(array);

int Input(string text)
{
    Console.Write(text);
    return Convert.ToInt32(Console.ReadLine());
}

void ArrayCreation(int column, int row)
{
    int[,] array = new int[column, row];

    for (int i = 0; i < column; i++)
    {
        for (int j = 0 ; j < row; j++)
        {
            array[i,j] = new Random().Next(0, 10);
            Console.Write(array[i,j] + " ");
        }
        Console.WriteLine();
    }
}

void FrequencyCheck(int[,] arrayCheck)
{
    int checkValue = 10;
    int count = 0;
    for (int k = 0; k < checkValue; k++)
    {
        for (int i = 0; i < arrayCheck.GetLength(0); i++)
        {
            for (int j = 0; j < arrayCheck.GetLength(1); j++)
            {
                    if (arrayCheck[i, j] == k)
                    {
                        count++;
                    }
            }
        }
        if (count != 0)
        {
            Console.WriteLine($"{k} встречается {count} раз(а)"); 
            count = 0;
        }
    }
}

