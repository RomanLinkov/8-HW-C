// Задача 56: Задайте прямоугольный двумерный массив. Напишите программу,
// которая будет находить строку с наименьшей суммой элементов.

// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// 5 2 6 7
// Программа считает сумму элементов в каждой строке и выдаёт 
// номер строки с наименьшей суммой элементов: 1 строка

Console.Clear();
Console.WriteLine("Здравствуйте! Спасибо, что проверяете моё дз и особенно большое спасибо за комментарии!");

int[,] twoDimIntArray = GenerationTwoDimIntArray();

FillTwoDimIntArray(twoDimIntArray);

PrintTwoDimIntArray(twoDimIntArray);

Console.WriteLine($"Строка c наименьшей суммой элементов, нумерация строк с 1: {SearchMinSumRow(twoDimIntArray)+1}");

void FillTwoDimIntArray(int[,] TwoDimIntArray2)
{
    int rows1=TwoDimIntArray2.GetLength(0); // число строк
    int columns1=TwoDimIntArray2.GetLength(1); // число столбцов
    int min=NumberInput("Введите минимальный элемент массива: ");
    int max=NumberInput("Введите максимальный элемент массива: ");

    for (int i = 0; i < rows1; i++)
    {
        for (int j = 0; j < columns1; j++)
        {
            TwoDimIntArray2[i,j]=new Random().Next(min,max+1);
        }
    }
}

int SearchMinSumRow(int[,] twoDimIntArray1)
{
    int rows=twoDimIntArray1.GetLength(0); // число строк
    int columns=twoDimIntArray1.GetLength(1); // число столбцов
    int[] rowsSum = new int[rows];

    for (int i = 0; i < rows; i++)
    {
        for (int j = 0; j < columns; j++)
        {
            rowsSum[i] = rowsSum[i] + twoDimIntArray1[i,j];
        }
    }

    int rowMaxSum = rowsSum[0];
    int imax = 0;
    for (int i = 1; i < rows; i++)
    {
        if (rowMaxSum > rowsSum[i]) 
        {
            rowMaxSum=rowsSum[i];
            imax = i;
        }
    }
    return imax;
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
    int n=NumberInput("Введите количество строк двумерного массива: ");
    int m=NumberInput("Введите количество столбцов двумерного массива: ");
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