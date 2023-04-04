// Напишите программу, которая на вход принимает позиции элемента 
// в двумерном массиве, и возвращает значение этого элемента или же
// указание, что такого элемента нет.

int InputNum(string message)
{
    Console.Write(message);
    return Convert.ToInt32(Console.ReadLine()!);
}

int[,] Create2DArray(int rows, int columns)
{
    return new int[rows, columns];
}

void Fill2DArray(int[,] array, int minValue, int maxValue)
{
    Random rnd = new Random();
    for  (int i = 0; i < array.GetLength(0); i++)
        for (int j = 0; j < array.GetLength(1); j++)
            array[i, j] = rnd.Next(minValue, maxValue + 1);
}

string Print2DArray(int[,] array)
{
    string res = String.Empty;
        for (int i = 0; i < array.GetLength(0); i++)
            for (int j = 0; j < array.GetLength(1); j++)
            {
                res += array[i, j];
                if (j != array.GetLength(1) - 1)
                    res += "\t";
                else
                    res += "\n";
            }
            return res;
}

bool SearchNumByIndex(int rows, int cols, int indI, int indJ)
{
    return indI >= 0 && indI < rows && indJ < cols; 
}

string IsElement(bool check, int[,] array, int indI, int indJ)
{
    string ans = "Нет такого элемента.";
    if(check) ans = $"Значение числа {array[indI, indJ]}.";
    return ans;
}

int numRows = InputNum("Введите номер строки: ");
int numCols = InputNum("Введите номер столбца: ");
int[,] myArray = Create2DArray(numRows, numCols);
int min = InputNum("Самое минимальное число: ");
int max = InputNum("Самое максимальное число: ");
Fill2DArray(myArray, min, max);
string result = Print2DArray(myArray);
Console.WriteLine(result);

int numRow = InputNum("Введите индекс строки: ");
int numCol = InputNum("Введите индекс столбца: ");

bool check = SearchNumByIndex(numRows, numCols, numRow, numCol);
string element = IsElement(check, myArray, numRow, numCol);
Console.WriteLine(element);
