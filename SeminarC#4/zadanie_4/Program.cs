// 30. Напишите программу, которая выводит массив из 8 элементов, заполненый нулями и единицами в случайном порядке
// [1,0,1,1,0,1,0,0]

int[] array = new int[8];

for (int index = 0; index < array.Length; index++)
{
    array[index] = new Random().Next(0,2);
    Console.Write($"{array[index]} ");
}

// Рандом через while
/* 
int index = 0;
while (index < array.Length)
{
    array[index] = new Random().Next(0,2);
    index++;
}
*/
// // Рандом через for
/*
for (int index = 0; index < array.Length; index++)
{
    array[index] = new Random().Next(0,2);
}
*/
// Вывод (Печать) массива через while
/*
int position = 0;
while (position < array.Length)
{
    Console.Write($"{array[position]},");
    position++;
}
*/
// Вывод (Печать) массива через for
// for (int position = 0; position < array.Length; position++)
// {
//     Console.Write($"{array[position]},");
// }