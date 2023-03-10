// Задача 54: Задайте двумерный массив. Напишите программу, 
// которая упорядочит по убыванию элементы каждой строки двумерного массива.

// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4

// В итоге получается вот такой массив:
// 1 2 4 7
// 2 3 5 9
// 2 4 4 8

Console.Clear();
Console.WriteLine("Здравствуйте! Спасибо, что проверяете моё дз и особенно большое спасибо за комментарии!");

int n=NumberInput("Введите количество строк двумерного массива: ");
int m=NumberInput("Введите количество столбцов двумерного массива: ");

int[,] twoDimIntArray = new int[n,m];;

int min=NumberInput("Введите минимальный элемент массива: ");
int max=NumberInput("Введите максимальный элемент массива: ");

FillTwoDimIntArray(twoDimIntArray, min, max);

PrintTwoDimIntArray(twoDimIntArray, "Сгенерированный изначальный массив: ");

int[,] sortedTwoDimIntArray = SortTwoDimIntArray(twoDimIntArray);

PrintTwoDimIntArray(sortedTwoDimIntArray, "Отсортированный массив: ");

int[,] SortTwoDimIntArray(int[,] twoDimIntArray3)
{
    int numRows=twoDimIntArray3.GetLength(0);
    int numColumns=twoDimIntArray3.GetLength(1);
    
    int[,] sortedArray = twoDimIntArray3; //new int[numRows,numColumns];

    for (int i = 0; i < numRows; i++)
    {
        bool b = true;
        while (b)
        {
            b=false;
            for (int j = 1; j < numColumns; j++)
            {
                if (sortedArray[i,j-1]>sortedArray[i,j])
                {
                    int temp = sortedArray[i,j-1];
                    sortedArray[i,j-1]=sortedArray[i,j];
                    sortedArray[i,j]=temp;
                    b=true;
                }
            }
        }
    }
    return sortedArray;
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

void PrintTwoDimIntArray(int[,] twoDimIntArray1, string msg)
{
    Console.WriteLine(msg);
    int rows=twoDimIntArray1.GetLength(0); // число строк
    int columns=twoDimIntArray1.GetLength(1); // число столбцов

    for (int i = 0; i < rows; i++)
    {
        for (int j = 0; j < columns; j++)
        {
            Console.Write($"{twoDimIntArray1[i,j]} ");
        }
        Console.WriteLine();
    }
}

int NumberInput(string msg)
{
    System.Console.Write(msg);
    string value = Console.ReadLine();
    int result = Convert.ToInt32(value);
    return result;
}