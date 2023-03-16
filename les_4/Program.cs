// 3. Задайте двумерный массив. Найдите сумму элементов главной диагонали.







int EvenPos(int[,] arr)
{
    int row = arr.GetLength(0);
    int column = arr.GetLength(1);

    int sum = 0;

    for (int i = 0; i < row; i++)
        for (int j = 0; j < column; j++)

            if (i == j)
                sum = sum + arr[i, j];

    return sum;            

}

int row_num = int.Parse(Console.ReadLine()!);
int column_num = int.Parse(Console.ReadLine()!);
int start = int.Parse(Console.ReadLine()!);
int stop = int.Parse(Console.ReadLine()!);

int[,] mass = MassNums(row_num, column_num, start, stop);
Print(mass);
int result = EvenPos(mass);
Console.WriteLine(result);
