// Задача 70: Напишите программу, которая на вход принимает два числа и выдаёт первые N чисел, 
// для которых каждое следующее равно сумме двух предыдущих.
// 3 и 4,  N = 5 -> 3 4 7 11 18
// 6 b 10, N = 4 -> 6 10 16 26

// int a = Input("Введите число A: ");
// int b = Input("Введите число B: ");
// int n = Input("Введите значение N: ");

// for (int i = 1; i <= n; i++)
// {
//     Console.Write(Summa(a, b, i) + " ");
// }

// int Summa(int a, int b, int n)
// {
//     if (n == 1)
//         return a;
//     if (n == 2)
//         return b;
//     else
//     {
//         int sum = Summa(a, b, n - 1) + Summa(a, b, n - 2);
//         return sum;
//     }
// }

// int Input(string text)
// {
//     Console.Write(text);
//     return Convert.ToInt32(Console.ReadLine());
// }


// int a = Input("Введите число A: ");
// int b = Input("Введите число B: ");
// int n = Input("Введите значение N: ");

// OutputNumbers(a, b, n);

// void OutputNumbers(int a, int b, int n)
// {
//     if (n == 2)
//     {
//         Console.Write($"{a} {b}");
//     }
//     else
//     {
//         Console.Write($"{a} ");
//         OutputNumbers(b, a + b, n - 1);
//     }
// }

// int Input(string text)
// {
//     Console.Write(text);
//     return Convert.ToInt32(Console.ReadLine());
// }


