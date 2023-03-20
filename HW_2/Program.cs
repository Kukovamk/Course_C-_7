// Напишите программу, которая на вход принимает позиции элемента 
// в двумерном массиве, и возвращает значение этого элемента или же
// указание, что такого элемента нет.


Console.WriteLine("Введите номер строки");
 int a = int.Parse(Console.ReadLine());
 Console.WriteLine("Введите номер столбца");
 int b = int.Parse(Console.ReadLine());
 int [,] num = new int (from, to);
 
void PrintArray(int[,] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
            arr[i, j] = new Random().Next(from, to);
    }
}

void Print(int[,] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j <array.GetLength(1); j++)
        {
            Console.Write(array[i, j] + " ");
        }
    Console.WriteLine("");    
    }
}
 if (a > num.GetLength(0) || b > num.GetLength(1))
 {
    Console.WriteLine("Такого элемента нет");
 }           
 else 
 {
    Console.WriteLine($"Значение элемента равно ");
 }

 PrintArray(num);