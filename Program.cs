// Задайте двумерный массив размером m×n, заполненный случайными целыми числами.
/*
Console.WriteLine("Введите значение строк");
int rows = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите значение столбцов");
int columns = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите минимальное значение массива");
int min = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите максимальное значение массива");
int max = Convert.ToInt32(Console.ReadLine());

int[,] CreateRandom2dArray(int rows, int columns, int min, int max)
{
    int[,] newArray = new int[rows, columns];

    for (int i = 0; i < rows; i++)
    {
        for (int j = 0; j < columns; j++)
        {
            newArray[i, j] = new Random().Next(min, max + 1);
        }
    }
    return newArray;
}

void Show2dArray(int[,] array)
{
    Console.WriteLine("Задан массив: ");
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            Console.Write(array[i, j] + " ");
        }
        Console.WriteLine();
    }
    Console.WriteLine();
}

int[,] MyArray = CreateRandom2dArray(rows, columns, min, max);
Show2dArray(MyArray);
*/

/* Задача 1. Задайте двумерный массив размера m на n, каждый элемент в массиве находится по формуле: Aij = i+j. 
Выведите полученный массив на экран.
Задача 2. Задайте двумерный массив. Найдите элементы, у которых оба индекса чётные, и замените эти элементы на их квадраты.
Задача 3. Задайте двумерный массив. Найдите сумму элементов, находящихся на главной диагонали (с индексами (0,0); (1;1) и т.д.
*/
/*
Console.WriteLine("Введите значение строк");
int rows = Convert.ToInt32(Console.ReadLine());                     //Задача 1
Console.WriteLine("Введите значение столбцов");
int columns = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите минимальное значение массива");
int min = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите максимальное значение массива");
int max = Convert.ToInt32(Console.ReadLine());

int[,] CreateRandom2dArray(int rows, int columns, int min, int max)
{
    int[,] newArray = new int[rows, columns];

    for (int i = 0; i < rows; i++)
    {
        for (int j = 0; j < columns; j++)
        {
            newArray[i, j] = i + j;
        }
    }
    return newArray;
}

void Show2dArray(int[,] array)
{
    Console.WriteLine("Задан массив: ");
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            Console.Write(array[i, j] + " ");
        }
        Console.WriteLine();
    }
    Console.WriteLine();
}

int[,] MyArray = CreateRandom2dArray(rows, columns, min, max);
Show2dArray(MyArray);
*/
/*
Console.WriteLine("Введите значение строк");
int rows = Convert.ToInt32(Console.ReadLine());                 //Задача 2
Console.WriteLine("Введите значение столбцов");
int columns = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите минимальное значение массива");
int min = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите максимальное значение массива");
int max = Convert.ToInt32(Console.ReadLine());

int[,] CreateRandom2dArray(int rows, int columns, int min, int max)
{
    int[,] newArray = new int[rows, columns];

    for (int i = 0; i < rows; i++)
    {
        for (int j = 0; j < columns; j++)
        {
            newArray[i, j] = new Random().Next(min, max + 1);
            if (i%2==0 && j%2 == 0) newArray[i,j] = newArray[i,j] * newArray[i,j];
        }
    }
    return newArray;
}

void Show2dArray(int[,] array)
{
    Console.WriteLine("Задан массив: ");
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            Console.Write(array[i, j] + " ");
        }
        Console.WriteLine();
    }
    Console.WriteLine();
}

int[,] MyArray = CreateRandom2dArray(rows, columns, min, max);
Show2dArray(MyArray);
*/

/*
Console.WriteLine("Введите значение строк");
int rows = Convert.ToInt32(Console.ReadLine());             //Задача 3
Console.WriteLine("Введите значение столбцов");
int columns = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите минимальное значение массива");
int min = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите максимальное значение массива");
int max = Convert.ToInt32(Console.ReadLine());

int[,] CreateRandom2dArray(int rows, int columns, int min, int max)
{
    int[,] newArray = new int[rows, columns];

    for (int i = 0; i < rows; i++)
    {
        for (int j = 0; j < columns; j++)
        {
            newArray[i, j] = new Random().Next(min, max + 1);
        }
    }
    return newArray;
}

void Show2dArray(int[,] array)
{
    Console.WriteLine("Задан массив: ");
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            Console.Write(array[i, j] + " ");
        }
        Console.WriteLine();
    }
    Console.WriteLine();
}

int[,] MyArray = CreateRandom2dArray(rows, columns, min, max);
Show2dArray(MyArray);

int SumDiagonal(int[,] array)
{
    int sum = 0;
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            if (i==j) sum = sum + array[i,j];
        }
    }
    return sum;
}
Console.WriteLine("Сумма эл-ов гл. диагонали = " + SumDiagonal(MyArray));
*/
