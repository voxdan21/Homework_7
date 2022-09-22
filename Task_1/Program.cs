// Задача 47. Задайте двумерный массив размером m×n, заполненный случайными вещественными числами.

// m = 3, n = 4.

// 0,5 7 -2 -0,2

// 1 -3,3 8 -9,9

// 8 7,8 -7,1 9

///////////////////////////////////////////////////////////////////////////////////////////////////

// метод заполнения двухмерного массива.

double[,] FillTwoDimensionalArray(double[,] array, int startRandom, int finishRandom)
{
    Random random = new Random();
    int startValue = startRandom;
    int endValue = finishRandom;

    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)

        {
            array[i, j] = Math.Round((random.Next(startValue, endValue) - random.NextDouble()), 2, MidpointRounding.ToZero);
        }
    }
    return array;
}

// метод вывода массива в консоль

void WriteTwoDimensionalArray(double[,] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)

        {
            Console.Write(array[i, j] + " ");
        }
        Console.WriteLine();
    }
}

// метод ввода колличества строк  в массив
int LineTwoDimensionalArray()
{
    Console.Write("Введите колличество строк в двухмерном массиве: ");
    bool parseNIsOk = int.TryParse(Console.ReadLine(), out int line);
    if (!parseNIsOk)
    {
        Console.WriteLine("Введено значение некорректного формата, введите заново");
        return LineTwoDimensionalArray();
    }
    else
    {
        return line;
    }
}

// метод ввода колличества столбцов в массив
int ColumnTwoDimensionalArray()
{
    Console.Write("Введите колличество столбцов в двухмерном массиве: ");
    bool parseNIsOk = int.TryParse(Console.ReadLine(), out int column);
    if (!parseNIsOk)
    {
        Console.WriteLine("Введено значение некорректного формата, введите заново");
        return ColumnTwoDimensionalArray();
    }
    else
    {
        return column;
    }
}

// метод создания массива двухмерного 
double[,] MakeTwoDimensionalArray()
{
    int line = LineTwoDimensionalArray();
    int column = ColumnTwoDimensionalArray();
    double[,] array = new double[line, column];
    return array;
}

// метод ввода отрезка рандомных цифр от .
int RandomNumbersStart()
{

    Console.Write("Введите начало отрезка рандомных цифр для заполнения массива: ");
    bool parseNIsOk = int.TryParse(Console.ReadLine(), out int start);
    if (!parseNIsOk)
    {
        Console.WriteLine("Введено значение некорректного формата, введите заново");
        return RandomNumbersStart();
    }
    else
    {
        return start;
    }

}

// метод ввода отрезка рандомных цифр до .
int RandomNumbersEnd()
{
    Console.Write("Введите конец отрезка рандомных цифр для заполнения массива: ");
    bool parseMIsOk = int.TryParse(Console.ReadLine(), out int finish);
    if (!parseMIsOk)
    {
        Console.WriteLine("Введено значение некорректного формата, введите заново");
        return RandomNumbersEnd();
    }
    else
    {
        return finish;
    }
}

//cделали массив
double[,] array = MakeTwoDimensionalArray();
// получили рандомные числа
int startRandom = RandomNumbersStart();
int finishtRandom = RandomNumbersEnd();
//заполнили рандомными числами
array = FillTwoDimensionalArray(array, startRandom, finishtRandom);
//вывели массив
WriteTwoDimensionalArray(array);