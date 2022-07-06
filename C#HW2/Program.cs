// Задайте двумерный массив. Напишите программу, которая
// упорядочит по убыванию элементы каждой строки двумерного массива.

int [,] Table (int n, int m)
{
    int [,] table = new int [n, m];
    return table;
}

void PrintArray(int[,] matr)
{
    for (int i = 0; i < matr.GetLength(0); i++)
    {
        for (int j = 0; j < matr.GetLength(1); j++)
        {
            Console.Write($"{matr[i, j]} ");
        }
        Console.WriteLine();
    }
}



void FillArray(int[,] matr)
{
    for (int i = 0; i < matr.GetLength(0); i++)
    {
        for (int j = 0; j < matr.GetLength(1); j++)
        {
            matr[i, j] = new Random().Next(1, 10);
        }
    }
}

void ShiftInLine(int[,] array, int col)
{
    int [] temp = new int [col];

    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            temp [j] = array[i,j];
        }

        Array.Sort(temp);
        Array.Reverse(temp);

        for(int j = 0; j < array.GetLength(1); j++)
        {
            array[i,j] = temp[j];
        }
    }
}



Console.WriteLine($"Введите количество строк: ");
int line = Convert.ToInt32(Console.ReadLine());
Console.WriteLine($"Введите количество столбцов: ");
int col = Convert.ToInt32(Console.ReadLine());

int [,] matrix = Table (line , col);
Console.WriteLine();

FillArray(matrix);
Console.WriteLine();
PrintArray(matrix);
Console.WriteLine();
ShiftInLine(matrix, col);
Console.WriteLine();
PrintArray(matrix);