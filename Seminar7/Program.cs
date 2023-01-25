/*int[] CreateRandomArray(int size, int minValue, int maxValue){
    int[] array = new int[size];
    for(int i = 0; i < size; i++){
        array[i] = new Random().Next(minValue, maxValue+1);
    }
    return array;
}
*/
/*
int[,] CreateTwoDimRandomArray()
{
    Console.Write("Input rows count: ");
    int row = Convert.ToInt32(Console.ReadLine());
    Console.Write("Input columns count: ");
    int column = Convert.ToInt32(Console.ReadLine());
    Console.Write("Input a minValue: ");
    int minValue = Convert.ToInt32(Console.ReadLine());
    Console.Write("Input a maxValue: ");
    int maxValue = Convert.ToInt32(Console.ReadLine());
    int[,] array = new int[row, column];
    for (int i = 0; i < row; i++)
        for (int j = 0; j < column; j++)
            array[i, j] = new Random().Next(minValue, maxValue + 1);
    return array;
}
*/
void Print2dArray(int[,] arr)
{
    for (int i = 0; i < arr.GetLength(0); i++)
    {
        for (int j = 0; j < arr.GetLength(1); j++)
            Console.Write(arr[i, j] + "\t");
        Console.WriteLine();
    }
    Console.WriteLine();
}

//int[,] newArray = CreateTwoDimRandomArray();
//Print2dArray(newArray);

// Задайте двумерный массив размера m на n, каждый элемент 
// в массиве находится по формуле: Aij = i+j. Выведите полученный массив на экран.
/*
int[,] CreateNew2dArray()
{
    Console.Write("Input rows count: ");
    int row = Convert.ToInt32(Console.ReadLine());
    Console.Write("Input columns count: ");
    int column = Convert.ToInt32(Console.ReadLine());

    int[,] array = new int[row, column];
    for (int i = 0; i < row; i++)
        for (int j = 0; j < column; j++)
            array[i, j] = i+j;
    return array;
}
int[,] newArray = CreateNew2dArray();
Print2dArray(newArray);
*/

// Задайте двумерный массив. Найдите элементы, у которых 
// оба индекса чётные, и замените эти элементы на их квадраты.
/*
int[,] CreateNew2dArray(int rows, int columns, int minValue, int maxValue)
{
    int[,] array = new int[rows, columns];
    for (int i = 0; i < rows; i++)
        for (int j = 0; j < columns; j++)
            array[i, j] = new Random().Next(minValue, maxValue + 1);
    return array;
}

void EvenIndexConvert(int[,] array){
    for(int i = 0; i < array.GetLength(0); i += 2){
        for(int j = 0; j < array.GetLength(0); j+= 2){
            array[i, j] = array[i, j] * array[i, j];
        }
    }
}
Console.Write("Input rows count: ");
int row = Convert.ToInt32(Console.ReadLine());
Console.Write("Input columns count: ");
int column = Convert.ToInt32(Console.ReadLine());
Console.Write("Input a minValue: ");
int minValue = Convert.ToInt32(Console.ReadLine());
Console.Write("Input a maxValue: ");
int maxValue = Convert.ToInt32(Console.ReadLine());

int[,] newArray = CreateNew2dArray(row, column, minValue, maxValue);
Print2dArray(newArray);
EvenIndexConvert(newArray);
Print2dArray(newArray);
EvenIndexConvert(newArray);*/

// Задайте двумерный массив. Найдите сумму элементов, 
// находящихся на главной диагонали (с индексами (0,0); (1;1) и т.д.

int[,] CreateNew2dArray(int rows, int columns, int minValue, int maxValue)
{
    int[,] array = new int[rows, columns];
    for (int i = 0; i < rows; i++)
        for (int j = 0; j < columns; j++)
            array[i, j] = new Random().Next(minValue, maxValue + 1);
    return array;
}

int SumMainDiagonal(int[,] array){
    int sum = 0;
    for(int i = 0; i < array.GetLength(0) && i < array.GetLength(1); i++){
        sum += array[i,i];
    }
    return sum;
}

Console.Write("Input rows count: ");
int row = Convert.ToInt32(Console.ReadLine());
Console.Write("Input columns count: ");
int column = Convert.ToInt32(Console.ReadLine());
Console.Write("Input a minValue: ");
int minValue = Convert.ToInt32(Console.ReadLine());
Console.Write("Input a maxValue: ");
int maxValue = Convert.ToInt32(Console.ReadLine());

int[,] newArray = CreateNew2dArray(row, column, minValue, maxValue);
Print2dArray(newArray);

int sum = SumMainDiagonal(newArray);
Console.WriteLine($"Sum of elements on main diagonale is {sum}");