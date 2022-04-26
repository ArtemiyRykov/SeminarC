/*17. Напишите программу, котороя принимает на вход координаты точки (Х и У), при чем Х и У не должны быть равны 0(нулю)
 и выдает номер четверти плоскости, в которой находится эта точка.*/


Console.Write("X: ");
int x = Convert.ToInt32(Console.ReadLine());
Console.Write("Y: ");
int y = Convert.ToInt32(Console.ReadLine());

if (x == 0 || y == 0)
 {
     Console.WriteLine("X и Y не могут быть равны 0");
     return;
 }

int quarterNumber = 0;
if (x > 0 && y > 0)
{
    quarterNumber = 1;
}
if(x < 0 && y > 0)
{
     quarterNumber = 2;
}
if(x < 0 && y < 0)
{
     quarterNumber = 3;
}
if(x > 0 && y < 0)
{
     quarterNumber = 4;
}
    
Console.WriteLine($"Точка находится в четвети номер: {quarterNumber}");