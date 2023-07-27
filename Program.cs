// Задача 52. Задайте двумерный массив из целых чисел.
// Найдите среднее арифметическое элементов в каждом столбце.

// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// Среднее арифметическое каждого столбца: 4,6; 5,6; 3,6; 3.

void PrintArray(double[] massive)
{
    for (int i = 0; i < massive.Length; i++)
    {
        Console.WriteLine($"Среднее арифметическое каждого столбца: {Math.Round(massive[i], 1)}");
    } 
}
void LocateArithmeticMean(int[,] massive)
{    
    double[] avgNumbers = new double[massive.GetLength(1)];
    for(int i = 0; i < massive.GetLength(1); i++)
    {
        double sum = 0;
        for(int j = 0; j < massive.GetLength(0); j++)
        {
            sum += massive[j, i];
        }
        avgNumbers[i] = sum / massive.GetLength(0);
    }
    PrintArray(avgNumbers);  
}

void Print2DMassive(int[,] massive)                              
{
    for(int i = 0; i < massive.GetLength(0); i++)
    {
        for(int j = 0; j < massive.GetLength(1); j++)
        {
            Console.Write($" {massive[i,j]} ");
        }
        Console.WriteLine();
    }
}

int[,] Create2DMassiv(int rows, int columns, int startValue, int finishValue)
{
    int[,] matrix = new int[rows,columns];
    for(int i = 0; i < matrix.GetLength(0); i++)
    {
        for(int j = 0; j < matrix.GetLength(1); j++)
        {
            matrix[i,j] = new Random().Next(startValue, finishValue + 1);
        }
    }
    return matrix;
}

int[,] massive = Create2DMassiv(3, 4, 1, 9);
Print2DMassive(massive);
LocateArithmeticMean(massive);