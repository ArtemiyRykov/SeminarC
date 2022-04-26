// 9. Напишите программу, которое выводит случайное число из отрезка [10,99] и показыает наибольшую цифру числаю.
// 78->8, 12->2, 85-> 8.

//int number = new Random().Next(10, 100); // получили рандомное число
int number = RandomInt(10, 100); // получение рандомного числа через функцию (смотреть ниже)
int first = number / 10; //целочисленное деление
int second = number % 10; //остаток от деления
Console.WriteLine(number);

/*if (first > second)
{
    Console.WriteLine(first);
}
else
{
    Console.WriteLine(second);
}*/
// напишем фунцию(метод) для нахождения наибольшего числа
int max = MaxNumber(first, second);
Console.WriteLine(max);

int MaxNumber(int number1, int number2) // функция нахождения максимального числа и двух чисел

{
    /*max = number1;
    if (max < number2)
    {
        max = number2;
    }
    return max;*/
    // ИЛИ
    if (number1 > number2)
        return number1;
    else
        return number2;

}

// Функция(метод) Который возвращает рандомное число
int RandomInt(int min, int max) // функция рандомного числа
{
    return new Random().Next(min, max); // inclusiveMin- минимальное число включительно, exclusiveMax - максимальное число включительно
}
