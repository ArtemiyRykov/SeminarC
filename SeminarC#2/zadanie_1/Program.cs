int sum = Sum(20, 30);
Print(Convert.ToString(sum));

int Sum(int numberOne, int numberTwo) // функция суммы двух чисел. возвращаемая функция
{
    int sum = numberOne + numberTwo;
    return sum;
}

void Print(string argument)          // функция вывод на печать. не возвращаемая функция
{
    Console.WriteLine(argument);
}