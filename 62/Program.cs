// Задача 62. Заполните спирально массив 4 на 4.
// Например, на выходе получается вот такой массив:
// 1 2 3 4
// 12 13 14 5
// 11 16 15 6
// 10 9 8 7


Console.Clear();
Console.WriteLine("Салам пополам!");

int rows = NumberInput("Введите количество строк двухмерного массива: ");
int columns = NumberInput("Введите количество столбцов двухмерного массива: ");

int[,] twoDimIntArray = new int[rows,columns];

PrintTwoDimIntArray(twoDimIntArray);

void SpringFill2DimIntArray(int[] array2Dim)
{
    for (int i = 0; i < array2Dim.GetLength(0); i++)
    {
        for (int j = 0; j < array2Dim.GetLength(1); j++)
        {
            if (array2Dim[i,j]==0)
            {

            }      
        }
    }
}

void SpringFill2DimIntArray(int[] array2Dim)
{
    int row = 0;
    int col = 0;
    int lngth = array2Dim.GetLength(0)*array2Dim.GetLength(1);

    int direction=0;

    for (int i = 0; i < lngth; i++)
    {
        array2Dim[row,col]=i;

        if (array2Dim(row,col+1)==0) direction=0;
        if (array2Dim(row-1,col)==0) direction=1;
        if (array2Dim(row,col-1)==0) direction=2;
        if (array2Dim(row+1,col)==0) direction=3;

        if (direction==0) col++;
        if (direction==1) row--;
        if (direction==2) col--;
        if (direction==3) row++;
        
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