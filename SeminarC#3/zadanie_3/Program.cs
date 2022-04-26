/*21. Напишите программу, которая принимает на вход координаты двух точек и находит растояние между ними в 2 D пространстве.
А(3,6);В(2,1)->5,09 , А(7,-5);В(1,1)->7,21*/


int xA = Cordinate("x", "A");
int yA = Cordinate("y", "A");
int xB = Cordinate("x", "B");
int yB = Cordinate("y", "B");

double x = Quarter(xA,xB);
double y = Quarter(yA,yB);

double result = Math.Sqrt(x+y);
Console.WriteLine(result);

double Quarter(double number1, double number2)
{
    return Math.Pow((number1 - number2), 2);
}


int Cordinate(string coorName, string pointName)
{
    Console.WriteLine($"Введите координаты {coorName} точки {pointName}: ");
    return Convert.ToInt16(Console.ReadLine());
}