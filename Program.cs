// Задача 1: Задайте двумерный массив. 
// Напишите программу, которая упорядочит по возрастанию элементы каждой строки двумерного массива.
/*
/*
Например, задан массив:
1 4 7 2
5 9 2 3
8 4 2 4

В итоге получается вот такой массив:
1 2 4 7
2 3 5 9
2 4 4 8
*/
/*
int[,] NewRandomArray(int m, int n)
{
    int[,] matrix = new int[m, n];
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            matrix[i, j] = new Random().Next(1, 10);
            Console.Write(matrix[i, j] + " ");
        }
        Console.WriteLine();
    }
    Console.WriteLine();
    return matrix;
}
*/
/*
int[,] IncreasingRows(int[,] matrix)
{
    int minPosition,
        temp;
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int j = 0; j < matrix.GetLength(1) - 1; j++)
        {
            minPosition = j;
            for (int k = j; k < matrix.GetLength(1); k++)
            {
                if (matrix[i, k] < matrix[i, minPosition]) minPosition = k;
            }
            temp = matrix[i, j];
            matrix[i, j] = matrix[i, minPosition];
            matrix[i, minPosition] = temp;
        }
    }
    return matrix;
}

void PrintArray(int[,] matrix)
{
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int j = 0; j < matrix.GetLength(1); j++)
            Console.Write(matrix[i, j] + " ");
        Console.WriteLine();
    }
}
*/
/*
int rows = new Random().Next(2, 6);
int columns = new Random().Next(2, 6);
Console.WriteLine("Вот наш массив:");
int[,] array = NewRandomArray(rows, columns);
*/
// Console.WriteLine("Измененный массив:");
// PrintArray(IncreasingRows(array));



// Задача 2: Задайте прямоугольный двумерный массив. 
// Напишите программу, которая будет находить строку с наименьшей суммой элементов.

/*
Например, задан массив:
1 4 7 2
5 9 2 3
8 4 2 4
5 2 6 7
Программа считает сумму элементов в каждой строке и выдаёт номер строки с наименьшей суммой элементов: 1 строка
*/
/*
int MinSumInRow (int[,] matrix)
{
    int minSum = 0;
    int minIndex = 0;
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        int sum = 0;
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            sum = sum + matrix[i,j];
        }
        Console.WriteLine ("Сумма элементов в " + i + " строке: " + sum);
        if (minSum > sum || i == 0)
        {
            minSum = sum;
            minIndex = i;
        }
    }
    return minIndex;
}
Console.WriteLine ("Индекс строки с наименьшей суммой элементов: " + MinSumInRow(array));
*/



// Задача 3: Сформируйте трёхмерный массив из неповторяющихся двузначных чисел.
// Напишите программу, которая будет построчно выводить массив, добавляя индексы каждого элемента.

/*
массив размером 2 x 2 x 2

12(0,0,0) 22(0,0,1)
75(0,1,0) 31(0,1,1)
45(1,0,0) 53(1,0,1)
32(1,1,0) 23(1,1,1)
*/
/*
void New3DArray(int x, int y, int z)
{
    int[, ,] matrix = new int[x, y, z];
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            for (int k = 0; k < matrix.GetLength(2); k++)
            {
            matrix[i, j, k] = 11 + i + j * k + y + k * x + j * y + z + y * k; 
            //мой вариант избежать повторения элементов :)
            Console.Write($"{matrix[i, j, k]}({i},{j},{k}) ");
            }
            Console.WriteLine();
        }   
    }
    Console.WriteLine();
}
New3DArray(2, 2, 2);
*/



// Задача 4: Заполните спирально массив 4 на 4.

/*
На выходе получается вот такой массив:

1  2  3  4
12 13 14 5
11 16 15 6
10 9  8  7
*/

void PrintMatrix(int[,] matrix)
{
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int j = 0; j < matrix.GetLength(1); j++)
            Console.Write($"{matrix[i, j]} ");
        Console.WriteLine();
    }
}

int[,] SnakeArray(int side)
{
    int[,] matrix = new int[side, side];
    int step = 1,
        column = side,
        row = side,
        initColumn = 0,
        initRow = 0;
    while (initColumn < column)
    {
        for (int i = initColumn; i < column; i++)
        {
            matrix[initRow, i] = step++;
        }
        column --;
        for (int j = initRow + 1; j < row; j++)
        {
            matrix[j, row - 1] = step++;
        }
        row --;
        for (int k = column - 1; k >= initColumn; k--)
        {
            matrix[column, k] = step++;
        }
        for (int l = row - 1; l > initRow; l--)
        {
            matrix[l, initColumn] = step++;
        }
        initColumn++;
        initRow++;
    }
    return matrix;
}
Console.WriteLine("Введите размерность квадратного массива для заполнения по принципу змейки: ");
int size = Convert.ToInt32(Console.ReadLine());
PrintMatrix(SnakeArray(size));