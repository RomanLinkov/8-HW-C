// Задача 58: Задайте две матрицы. Напишите программу, которая будет находить произведение двух матриц.
// Например, заданы 2 массива:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// 5 2 6 7

// и

// 1 5 8 5
// 4 9 4 2
// 7 2 2 6
// 2 3 4 7

//  В этой задаче я буду реализовывать правила умножения матриц, а не делать как в задании.

Console.Clear();
Console.WriteLine("Здравствуйте! Спасибо, что проверяете моё дз и особенно большое спасибо за комментарии!");

Console.WriteLine("Задайте размер массивов: ");

int n1=NumberInput("Введите количество строк матрицы 1: ");
int m1=NumberInput("Введите количество столбцов матрицы 1: ");

int n2=NumberInput("Введите количество строк матрицы 2: ");
int m2=NumberInput("Введите количество столбцов матрицы 2: ");

if (n2!=m1)
{
    Console.WriteLine("Эти матрицы нельзя умножить. Попробуйте снова.");
    return;
}

int[,] twoDimIntArray1 = new int[n1,m1];
int[,] twoDimIntArray2 = new int[n2,m2];

int min=NumberInput("Введите минимальный элемент матрицы: ");
int max=NumberInput("Введите максимальный элемент матрицы: ");

FillTwoDimIntArray(twoDimIntArray1, min, max);
FillTwoDimIntArray(twoDimIntArray2, min, max);

Console.WriteLine("Первая матрица");
PrintTwoDimIntArray(twoDimIntArray1);
Console.WriteLine("Вторая матрица");
PrintTwoDimIntArray(twoDimIntArray2);

int[,] multiplicationArrays=MultiplicationMatrix(twoDimIntArray1, twoDimIntArray2);

Console.WriteLine("Произведение матриц: ");
PrintTwoDimIntArray(multiplicationArrays);

int[,] MultiplicationMatrix(int[,] array1, int[,] array2)
{
    int rows1 = array1.GetLength(0);
    int columns2 = array2.GetLength(1);
    int columns1 = array1.GetLength(1);

    int[,] resArray = new int[rows1,columns2];

    for (int i = 0; i < rows1; i++)
    {
        for (int j = 0; j < columns2; j++)
        {
            int temp = 0;
            for (int k = 0; k < columns1; k++)
            {
                temp = temp + array1[i,k]*array2[k,j];
            }
            resArray[i,j] = temp;
        }
    }
    return resArray;
}

void FillTwoDimIntArray(int[,] TwoDimIntArray2, int min, int max)
{
    int rows1=TwoDimIntArray2.GetLength(0); // число строк
    int columns1=TwoDimIntArray2.GetLength(1); // число столбцов

    for (int i = 0; i < rows1; i++)
    {
        for (int j = 0; j < columns1; j++)
        {
            TwoDimIntArray2[i,j]=new Random().Next(min,max+1);
        }
    }
}

void PrintTwoDimIntArray(int[,] twoDimIntArray1)
{
    int rows=twoDimIntArray1.GetLength(0); // число строк
    int columns=twoDimIntArray1.GetLength(1); // число столбцов

    for (int i = 0; i < rows; i++)
    {
        int[] rowsSum = new int[rows];
        for (int j = 0; j < columns; j++)
        {
            rowsSum[i] = rowsSum[i] + twoDimIntArray1[i,j];
            Console.Write($"{twoDimIntArray1[i,j]} ");
        }
        Console.WriteLine();
        // Console.WriteLine($" -> Сумма элементов строки {rowsSum[i]}"); Выведет сумму элеметов в важдой строке
    }
}

int NumberInput(string msg)
{
    System.Console.Write(msg);
    string value = Console.ReadLine();
    int result = Convert.ToInt32(value);
    return result;
}