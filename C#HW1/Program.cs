// Задайте двумерный массив, напишите программу,
// ктороая будет находить строку с наименьшей суммой элементов.

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

int [] Array (int number)
{
    int [] array = new int [number];
    return array;
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

int [] SerchSumElementsInLins(int[,] array, int [] arr)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            arr[i] = arr[i] + array [i, j];
        }
    // Console.WriteLine($"Arr {i + 1} = {arr[i]}");
    }

return arr;
}

void MinSumElements (int [] arr)
{
    int min = 0;

    for (int i = 0; i < arr.Length - 1; i++)
    {
        if (arr[i] < arr[min]) 
        {
            min = i;
        }
        for (int j = i + 1; j < arr.Length; j++)
        {
            if(arr[j] < arr[min]) 
            {
                min = j;
            }
        }
    }
    Console.WriteLine($"Line {min+1} = {arr[min]}");
}

Console.WriteLine($"Введите количество строк: ");
int n = Convert.ToInt32(Console.ReadLine());
Console.WriteLine($"Введите количество столбцов: ");
int m = Convert.ToInt32(Console.ReadLine());

int [,] matrix = Table (n , m);
Console.WriteLine();
int [] array = Array(n);

FillArray(matrix);
PrintArray(matrix);
int [] arr = SerchSumElementsInLins(matrix, array);
Console.WriteLine();
MinSumElements(arr);