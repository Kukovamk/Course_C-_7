// Задайте двумерный массив размером m*n, заполненный
// случайными вещественными числами. 

void Print(double[,] arr)
{
    int row = arr.GetLength(0);
    int column = arr.GetLength(1);

    for (int i = 0; i < row; i++)
    {
        for (int j = 0; j < column; j++)
            Console.Write(arr[i, j] + " ");
        Console.WriteLine();
    }
}

double[,] MassNums(double row, double column, double from, double to)
{
    double[,] arr = new double[row, column];

    for (int i = 0; i < row; i++)
        for (int j = 0; j < column; j++)
            arr[i, j] = Convert.ToDouble(new Random().Next(from, to));
    return arr;
}

int row_num = Convert.ToInt32(Console.ReadLine()!);
int column_num =Convert.ToInt32(Console.ReadLine()!);
int start =Convert.ToInt32(Console.ReadLine()!);
int stop = Convert.ToInt32(Console.ReadLine()!);

double[,] mass = MassNums(row_num, column_num, start, stop);
Print(mass);
