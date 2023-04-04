void InputMatrix(int[,] matrix)
{
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            matrix[i, j] = new Random().Next(-10, 11); // [-10, 10]
        }
    }
}

void PrintMatrix(int[,] matrix)
{
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            Console.Write($"{matrix[i, j]} \t");
        }
        Console.WriteLine();
    }
}

void MinSumNumbers(int[,] matrix)
{
    int min = 0;
    int minsum = 0;
    int sum = 0;
    for (int i = 0; i < matrix.GetLength(1); i++)
    {
        min = min + matrix[0, i];
    }
        for (int i = 0; i < matrix.GetLength(0); i++)
        {
            for (int j = 0; j < matrix.GetLength(1); j++) 
            {
                minsum = minsum + matrix[i, j];
            }
                if (minsum < min)
                {
                    min = minsum;
                    sum = i;
                }
        minsum = 0;
        }
    Console.Write($"{sum + 1} строка");
    Console.WriteLine();
}


Console.Clear();
int[,] matrix = new int[3,4];
Console.WriteLine("Дан массив:");
InputMatrix(matrix);
PrintMatrix(matrix);
MinSumNumbers(matrix);