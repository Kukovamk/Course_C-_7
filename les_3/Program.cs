// 2. Задайте двумерный массив. Найдите элементы,
//    у которых обе позиции чётные, и замените эти элементы на их квадраты.








void EvenPos(int[,] arr)
{
    int row = arr.GetLength(0);
    int column = arr.GetLength(1);

    for (int i = 1; i < row; i+=2)
        for (int j = 1; j < column; j+=2)
            arr[i, j] = arr[i,j] * arr[i, j];

}

int row_num = int.Parse(Console.ReadLine()!);
int column_num = int.Parse(Console.ReadLine()!);
int start = int.Parse(Console.ReadLine()!);
int stop = int.Parse(Console.ReadLine()!);

int[,] mass = MassNums(row_num, column_num, start, stop);
Print(mass);
EvenPos(mass);
Print(mass);