/*  **Задача 47**
Задайте двумерный массив размером m×n, заполненный случайными вещественными числами.
m = 3, n = 4.

0,5 7 -2 -0,2
1 -3,3 8 -9,9
8 7,8 -7,1 9    */

int m, n;
Console.WriteLine("Enter the m dimension of the array: ");
int.TryParse(Console.ReadLine()!, out m);
Console.WriteLine("Enter the n dimension of the array: ");
int.TryParse(Console.ReadLine()!, out n);
double[,] array = new double[m, n];
for (int i = 0; i < array.GetLength(0); i++)
{
    for (int j = 0; j < array.GetLength(1); j++)
    {
        array[i, j] = new Random().Next(-100, 100) / 10.0;
        if ((array[i, j]*10) % 10 != 0)
        {
            if (array[i, j] < 0)
            {
                Console.Write($"{array[i, j]}  ");
            }
            else
            {
                Console.Write($" {array[i, j]}  ");
            }
        }
        else
        {
            if (array[i, j] < 0)
            {
                Console.Write($"{array[i, j]}    ");
            }
            else
            {
                Console.Write($" {array[i, j]}    ");
            }
        }
    }
    Console.WriteLine();
}