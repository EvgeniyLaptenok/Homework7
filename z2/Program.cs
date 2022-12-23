/*Задача 50. Напишите программу, которая на вход принимает позиции элемента в двумерном массиве, 
и возвращает значение этого элемента или же указание, что такого элемента нет.
Например, задан массив:
1 4 7 2
5 9 2 3
8 4 2 4
1
7 -> такого числа в массиве нет
*/
Console.Write("Введите m: ");
int m = int.Parse(Console.ReadLine()!);
Console.Write("Введите n: ");
int n = int.Parse(Console.ReadLine()!);

int[,] matrix = Create2DArray(m, n);
Print2DArray(matrix);
Position(matrix);

void Position(int[,] matrix)
{
    Console.Write("Введите значение строки: ");
    int x = int.Parse(Console.ReadLine()!);
    Console.Write("Введите значение стобца: ");
    int y = int.Parse(Console.ReadLine()!);
    
    if (x < matrix.GetLength(0) && y < matrix.GetLength(1))
    {
        Console.WriteLine(matrix[x, y]);
    }
    else
    {
        Console.WriteLine("Такого элемента не существует");
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