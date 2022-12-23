/*Задача 52. Задайте двумерный массив из целых чисел. 
Найдите среднее арифметическое элементов в каждом столбце.
Например, задан массив:
1 4 7 2
5 9 2 3
8 4 2 4
Среднее арифметическое каждого столбца: 4,6; 5,6; 3,6; 3.
*/
Console.Write("Введите m: ");
int m = int.Parse(Console.ReadLine()!);
Console.Write("Введите n: ");
int n = int.Parse(Console.ReadLine()!);

int[,] matrix = Create2DArray(m, n);
Print2DArray(matrix);
Console.WriteLine();
Average(matrix);

void Average(int[,] matrix)
{
    double average = 0;
    for (int i = 0; i < matrix.GetLength(1); i++)
    {
        double sum = 0;
        int j = 0;
        while (j < matrix.GetLength(0))
        {
            sum += matrix[j, i];
            j++;
        }
        average = Math.Round(sum / matrix.GetLength(0), 2);
        Console.WriteLine(average);
    }
}

int[,] Create2DArray(int m, int n)
{
    int[,] matrix = new int[m, n];

    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            matrix[i, j] = new Random().Next(-10, 50);
        }
    }
    return matrix;
}

void Print2DArray(int[,] matrix)
{
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            Console.Write(matrix[i, j] + " ");
        }
        Console.WriteLine();
    }
}