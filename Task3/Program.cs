
int ReadInt(string message)
{
    Console.Write(message);
    return Convert.ToInt32(Console.ReadLine());
}

void FillArrayRandom(int[,] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            array[i, j] = new Random().Next(1, 10);
        }
    }
}

void PrintArray(int[,] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            Console.Write($"{array[i, j]} \t");
        }
        Console.WriteLine();
    }
}

void ResultArr(int[,] array, int[,] secondArray, int[,] resultArray)
{
if (array.GetLength(0) != secondArray.GetLength(1))
{
    Console.WriteLine(" Нельзя перемножить ");
    return;
}
for (int i = 0; i < array.GetLength(0); i++)
{
    for (int j = 0; j < secondArray.GetLength(1); j++)
    {
        resultArray[i, j] = 0;
        for (int k = 0; k < array.GetLength(1); k++)
        {
            resultArray[i, j] += array[i, k] * secondArray[k, j];// resultArray[i, j] = resultArray[i, j] + array[i, k] * secondArray[k, j](формула произведения матриц)
        }
    }
}
}

Console.Clear();
int rows = ReadInt("Введите количество строк: ");
int columns = ReadInt("Введите количество столбцов: ");
int[,] array = new int[rows, columns];
int[,] secondArray = new int[rows, columns];
int[,] resultArray = new int[rows, columns];
Console.WriteLine("Первая матрица: ");
FillArrayRandom(array);
PrintArray(array);
Console.WriteLine();
Console.WriteLine("Вторая матрица: ");
FillArrayRandom(secondArray);
PrintArray(secondArray);
Console.WriteLine();
Console.WriteLine("Результат умножения двух матриц: ");
ResultArr(array,secondArray,resultArray);
PrintArray(resultArray);