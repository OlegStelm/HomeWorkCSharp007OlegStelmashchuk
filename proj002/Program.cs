/*  **Задача 50**
Напишите программу, которая на вход принимает позиции элемента в двумерном массиве, и возвращает значение этого элемента или же указание, что такого элемента нет.
Например, задан массив:
1 4 7 2
5 9 2 3
8 4 2 4
17 -> такого числа в массиве нет    */
/*
int ie;
int j;
int FindNum = 0;
Console.WriteLine("Enter the m dimension of the array: ");
int.TryParse(Console.ReadLine()!, out ie);
Console.WriteLine("Enter the n dimension of the array: ");
int.TryParse(Console.ReadLine()!, out je);
Console.WriteLine();
int[,] array = new int[3, 4];
for (int i = 0; i < array.GetLength(0); i++)
{
    for (int j = 0; j < array.GetLength(1); j++)
    {
        array[i, j] = new Random().Next(10);
        Console.Write($"{array[i, j]} ");
        if (m == array[i, j])
        {
            FindNum = 1;
        }
    }
    Console.WriteLine();
}
if (m > -1 && m < 10)
    if (FindNum == 1)
    {
    Console.WriteLine("Your number is present in the array!");
    }
    else
    {
    Console.WriteLine("Your number is not in the array!");
    }
else
{
    Console.WriteLine("You entered a number outside the specified range!");
}
*/


int ie;
int je;
int FindIndex = 0;
Console.WriteLine("Enter the m dimension of the array: ");
int.TryParse(Console.ReadLine()!, out ie);
Console.WriteLine("Enter the n dimension of the array: ");
int.TryParse(Console.ReadLine()!, out je);
Console.WriteLine();
int[,] array = new int[3, 4];
for (int i = 0; i < array.GetLength(0); i++)
    {
    for (int j = 0; j < array.GetLength(1); j++)
    {
        array[i, j] = new Random().Next(10);
        Console.Write($"{array[i, j]} ");
        if (ie < 0 || ie >= array.GetLength(0))
            FindIndex = 0;
        else if (je < 0 || je >= array.GetLength(1))
        {
            FindIndex = 0;
        }
        else
            FindIndex = 1;
    }
Console.WriteLine();
    }
if (FindIndex == 0)
{
    Console.WriteLine("You have entered an index outside the specified array!");
}
else
{
    Console.WriteLine($"Search index value - {array[ie, je]}");
}
