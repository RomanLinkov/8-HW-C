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

SpringFill2DimIntArray(twoDimIntArray);

PrintTwoDimIntArray(twoDimIntArray);

void SpringFill2DimIntArray(int[,] array2Dim)
{
    int row = 0;
    int col = 0;
    int lngth = array2Dim.GetLength(0)*array2Dim.GetLength(1);

    int direction=0;

    array2Dim[0,0]=1;
    bool b = true;  
    
    int i = 2;
    while (i <= lngth)
    {
        if (direction==0 & col+1 < array2Dim.GetLength(1)) {if (array2Dim[row,col+1]==0) col++; b=false;}
        if (direction==1 & row+1 < array2Dim.GetLength(0)) {if (array2Dim[row+1,col]==0) row++; b=false;} 
        if (direction==2 & col-1 >=0) {if (array2Dim[row,col-1]==0) col=col-1; b=false;} 
        if (direction==3 & row-1 >=0) {if (array2Dim[row-1,col]==0) row=row-1; b=false;}

        if (b) direction=ChooseDirection(array2Dim, row, col);

        if (array2Dim[row,col]==0) 
        {
            array2Dim[row,col]=i;
            Console.WriteLine($"{row}, {col} -> {i} -> dir {direction}");
            i++;
            b = true;
        }
        else direction=ChooseDirection(array2Dim, row, col); 
    }   
}

int ChooseDirection(int[,] array2Dim1, int row, int col)
{
        Console.WriteLine($"{row}, {col} -> {array2Dim1[row,col]} choose dir");
        if (col+1<array2Dim1.GetLength(1))
        {
            if (array2Dim1[row,col+1]==0) return 0;
        }

        if (row+1<array2Dim1.GetLength(0)) 
        {
            if (array2Dim1[row+1,col]==0) return 1;
        }
       
        if (col-1>=0) 
        { 
            if (array2Dim1[row,col-1]==0) return 2;
        }

        if (row-1>=0) 
        {
            if (array2Dim1[row-1,col]==0) return 3;
        }
        return 0;
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