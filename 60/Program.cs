// Задача 60. Сформируйте трёхмерный массив из неповторяющихся двузначных чисел. 
// Напишите программу, которая будет построчно выводить массив, добавляя индексы каждого элемента.

// массив размером 2 x 2 x 2
// 12(0,0,0) 22(0,0,1)
// 45(1,0,0) 53(1,0,1)

Console.Clear();
Console.WriteLine("Салам пополам!");


int[,,] array3Dim = new int[2,2,3];



Print3DimArray(array3Dim);

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
