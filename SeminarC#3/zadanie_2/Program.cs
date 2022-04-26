/*18. Напишите программу, которая по заданному номеру четверти,
показывает диапозон возможных координат точек в этой четверти (х и у).*/

//Int.MaxValue, Int.MinValue - максимальное и минимальное заполнение int

Console.Write("Введите номер четверти от 1 до 4: ");
int quarterNumber = Convert.ToInt16(Console.ReadLine());

if(quarterNumber < 1 || quarterNumber > 5)
{
    Console.WriteLine("Не корректный ввод!");
    return;
}

if(quarterNumber == 1)
{
    Console.WriteLine($"х от 0 до {Int16.MaxValue}");
    Console.WriteLine($"y от 0 до {Int16.MaxValue}");
}

if(quarterNumber == 2)
{
    Console.WriteLine($"х от 0 до {Int16.MinValue}");
    Console.WriteLine($"y от 0 до {Int16.MaxValue}");
}

if(quarterNumber == 3)
{
    Console.WriteLine($"х от 0 до {Int16.MinValue}");
    Console.WriteLine($"y от 0 до {Int16.MinValue}");
}

if(quarterNumber == 4)
{
    Console.WriteLine($"х от 0 до {Int16.MaxValue}");
    Console.WriteLine($"y от 0 до {Int16.MinValue}");
}