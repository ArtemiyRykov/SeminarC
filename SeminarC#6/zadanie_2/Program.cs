// Задача 40: Напишите программу, которая принимает на вход три числа и проверяет, может ли существовать треугольник с сторонами 
// такой длины. "Теорема о неравенстве треугольника: каждая сторона треугольника меньше суммы двух других сторон."

int a = InputNumber("A");
int b = InputNumber("B");
int c = InputNumber("C");

if(a<b+c && b<a+c && c<a+b)
{
    Console.WriteLine("Это треугольник");
}
else Console.WriteLine("Это НЕ треугольник");



int InputNumber(string name)
{
    Console.Write($"Ведите число {name}: ");
    int number = Convert.ToInt32(Console.ReadLine());
    return number;
}





