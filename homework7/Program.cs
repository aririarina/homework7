void FillArray(int[,] matrix, int MinValue = -9, int MaxValue = 9) 
{
    MaxValue++;
    Random random = new Random();
    for(int i = 0; i < matrix.GetLength(0); i++)
    {
        for(int j = 0; j < matrix.GetLength(1); j++)
        {
            matrix[i,j] = random.Next(MinValue, MaxValue);
        }
    }
}

void PrintArray(int[,] matrix)
{
     for(int i = 0; i < matrix.GetLength(0); i++)
    {
        for(int j = 0; j < matrix.GetLength(1); j++)
        {
            Console.Write($"{matrix[i, j]}\t");
        }
        Console.WriteLine();
    }
}

int Input(string text)
{
    Console.Write(text);
    return Convert.ToInt32(Console.ReadLine());
}

void FillArrayDouble(double[,] matrix, int MinValue = -9, int MaxValue = 9) 
{
    MaxValue++;
    Random random = new Random();
    for(int i = 0; i < matrix.GetLength(0); i++)
    {
        for(int j = 0; j < matrix.GetLength(1); j++)
        {
            matrix[i,j] = random.NextDouble() * (MaxValue - MinValue) + MinValue;
            matrix[i,j] = Math.Round(matrix[i,j], 2);
        }
    }
}

void PrintArrayDouble(double[,] matrix)
{
     for(int i = 0; i < matrix.GetLength(0); i++)
    {
        for(int j = 0; j < matrix.GetLength(1); j++)
        {
            Console.Write($"{matrix[i, j]}\t");
        }
        Console.WriteLine();
    }
}

void Task47()
{
    // Задайте двумерный массив размером m×n, заполненный случайными вещественными числами, округлёнными до одного знака.
    
    int rows = 4;
    int colums = 6;
    double[,] numbers = new double[rows, colums];

    FillArrayDouble(numbers, -100, 100); 
    PrintArrayDouble(numbers);
}

void Task50()
{
    // Напишите программу, которая на вход принимает индексы элемента в двумерном массиве, 
    // и возвращает значение этого элемента или же указание, что такого элемента нет.

    int rows = 4;
    int colums = 6;
    int[,] numbers = new int[rows, colums];

    FillArray(numbers, -100, 100); 
    PrintArray(numbers);

    int indexRow = Input("введите индекс строки: ");
    int indexColumn = Input("введите индекс столбца: ");

    if(indexRow >= 0 && indexRow < rows &&
        indexColumn >= 0 && indexColumn < colums)
    {
        Console.WriteLine($"элемент {numbers[indexRow, indexColumn]}");
    }
    else Console.WriteLine("такого элемента нет");
}

void Task52()
{
    // Задайте двумерный массив из целых чисел. Найдите среднее арифметическое элементов в каждом столбце.
    
    int rows = 4;
    int columns = 6;
    int[,] numbers = new int[rows, columns];

    FillArray(numbers, -10, 10); 
    PrintArray(numbers);
    Console.WriteLine();

    for(int j = 0; j < columns; j++)
    {
        double sum = 0;
        for(int i = 0; i < rows; i++)
        {
            sum += numbers[i, j];
        }
        double result = sum/rows;
        Console.Write($"{result}\t");
    }
}

Task52();