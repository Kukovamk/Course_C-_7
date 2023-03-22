// Задайте двумерный массив из целых чисел. 
// Найдите среднее арифметическое элементов в каждом столбце.

void Print(int[,] arr)
{
    int row = arr.GetLength(0);
    int column = arr.GetLength(1);

    for (int i = 0; i < row; i++)
    {
        for (int j = 0; j < column; j++)
            Console.Write($" {arr[i, j]} ");
        Console.WriteLine();
    }
    Console.WriteLine();
    
}
int[,] MassNums(int row, int column, int from, int to)
{
    int[,] arr = new int[row, column];

    for (int i = 0; i < row; i++)
        for (int j = 0; j < column; j++)
            arr[i, j] = new Random().Next(from, to);
    return arr;
}
double ColumnAverage(int[,] arr)
{
     double[] average = new double[arr.GetLength(1)];
    for (int i = 0; i < arr.GetLength(1); i++)
    {
        for (int j = 0; i < arr.GetLength; j++)
            average[i] += arr[j, i];
        average [i] /= arr.GetLength(0);
    }      
    return average;            

}

int row_num = int.Parse(Console.ReadLine()!);
int column_num = int.Parse(Console.ReadLine()!);
int start = int.Parse(Console.ReadLine()!);
int stop = int.Parse(Console.ReadLine()!);

int[,] mass = MassNums(row_num, column_num, start, stop);
Print(mass);
double[] avg = ColumnAverage(mass);
Console.WriteLine(avg);

