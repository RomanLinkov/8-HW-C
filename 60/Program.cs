// Задача 60. Сформируйте трёхмерный массив из неповторяющихся двузначных чисел. 
// Напишите программу, которая будет построчно выводить массив, добавляя индексы каждого элемента.

// массив размером 2 x 2 x 2
// 12(0,0,0) 22(0,0,1)
// 45(1,0,0) 53(1,0,1)

Console.Clear();
Console.WriteLine("Салам пополам!");

int levels = NumberInput("Введите количество уровней трёхмерного массива: ");
int rows = NumberInput("Введите количество строк трёхмерного массива: ");
int columns = NumberInput("Введите количество столбцов трёхмерного массива: ");

if (levels*rows*columns>90)
{
    Console.WriteLine("В массиве не может быть больше 90 не одинаковых двухзначных чисел. Попробуйте снова.");
    return;
}

int[,,] array3Dim = new int[levels,rows,columns];

Fill3DArray(array3Dim);

Print3DimArray(array3Dim);

void Fill3DArray(int[,,] array3D)
{
    int levels1=array3D.GetLength(0);
    int rows1=array3D.GetLength(1);
    int columns1=array3D.GetLength(2);

    int lngth1=levels1*rows1*columns1;

    int[] tempArray = DifferentNumbersGeneration(lngth1, 10, 99);

    for (int s = 0; s < lngth1; s++)
    {
        for (int i = 0; i < levels1; i++)
        {
            for (int j = 0; j < rows1; j++)
             {
                 for (int k = 0; k < columns1; k++)
                 {
                    array3D[i,j,k]=tempArray[s];
                    s++;
                 }
            }   
        }
    }
}

int[] DifferentNumbersGeneration(int lngth, int min, int max)
{
    int[] diffNumbersArray = new int[lngth];

    int i = 0;
    while (i<lngth)
    {
        int value = new Random().Next(min,max+1);
        bool b = true;

        for (int j = 0; j < i+1; j++)
        {
            if (value==diffNumbersArray[j])
            {
                b=false;
                // break;
            }
            
        }

        if (b) 
        {
            diffNumbersArray[i] = value;
            i++;
        }
    }
    return diffNumbersArray;
}

void Print3DimArray(int[,,] array3Dim1)
{
    for (int i = 0; i < array3Dim1.GetLength(0); i++)
    {
        Console.WriteLine($"Уровень i = {i}");
        for (int j = 0; j < array3Dim1.GetLength(1); j++)
        {
            for (int k = 0; k < array3Dim1.GetLength(2); k++)
            {
                Console.Write($"{array3Dim1[i,j,k]}({i},{j},{k}) ");
            }
            Console.WriteLine();
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