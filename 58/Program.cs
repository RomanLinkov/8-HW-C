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

// Их произведение будет равно следующему массиву:
// 1 20 56 10
// 20 81 8 6
// 56 8 4 24
// 10 6 24 49

Console.Clear();
Console.WriteLine("Здравствуйте! Спасибо, что проверяете моё дз и особенно большое спасибо за комментарии!");

Console.WriteLine("Задайте размер массивов: ");

int[,] twoDimIntArray1 = GenerationTwoDimIntArray();
int[,] twoDimIntArray2 = twoDimIntArray1;

int min=NumberInput("Введите минимальный элемент массивов: ");
int max=NumberInput("Введите максимальный элемент массивов: ");

FillTwoDimIntArray(twoDimIntArray1, min, max);
FillTwoDimIntArray(twoDimIntArray2, min, max);

Console.WriteLine("Первый массив");
PrintTwoDimIntArray(twoDimIntArray1);
Console.WriteLine("Второй массив");
PrintTwoDimIntArray(twoDimIntArray2);

int[,] multiplicationArrays=MultiplicationArays(twoDimIntArray1, twoDimIntArray2);

Console.WriteLine("Произведение массивов: ");
PrintTwoDimIntArray(multiplicationArrays);

int[,] MultiplicationArays(int[,] array1, int[,] array2)
{
    int rows1 = array1.GetLength(0);
    int columns1 = array1.GetLength(1);
    int[,] resArray = new int[rows1,columns1];

    for (int i = 0; i < rows1; i++)
    {
        for (int j = 0; j < columns1; j++)
        {
            resArray[i,j] = array1[i,j]*array2[i,j];
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

int[,] GenerationTwoDimIntArray()
{
    int n=NumberInput("Введите количество строк массивов: ");
    int m=NumberInput("Введите количество столбцов массивов: ");
    int[,] twoDimIntArray = new int[n,m];
    return twoDimIntArray;
}

int NumberInput(string msg)
{
    System.Console.Write(msg);
    string value = Console.ReadLine();
    int result = Convert.ToInt32(value);
    return result;
}