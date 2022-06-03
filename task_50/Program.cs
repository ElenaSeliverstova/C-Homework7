// Задача 50: Напишите программу, которая на вход принимает позиции элемента в двумерном массиве, и
// возвращает значение этого элемента или же указание,что такого элемента нет.
// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// 17 -> такого числа в массиве нет

int[,] GetArray(int a, int b)
{
    int[,] array = new int[a, b];
    Random rnd = new Random();
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            array[i, j] = rnd.Next(-10, 10);
        }
    }
    return array;
}

void PrintArray(int[,] array)
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

void FindNum(int[,] numbersGrid)
{
    Console.WriteLine("Введите адрес элемента массива (2 числа через пробел): ");
    string[] inputNumbers = Console.ReadLine().Split();
    int inputRow = int.Parse(inputNumbers[0]);
    int inputColumn = int.Parse(inputNumbers[1]);

    bool isRowInRange = (0 <= inputRow) && (inputRow < numbersGrid.GetLength(0));
    bool isColInRange = (0 <= inputColumn) && (inputColumn < numbersGrid.GetLength(1));

    if (isRowInRange && isColInRange)
    {
        Console.WriteLine($"Значение элемента массива: {numbersGrid[inputRow, inputColumn]}");
    }
    else
    {
        Console.WriteLine("адрес не существует");
    }
}


int[,] table = GetArray(5, 5);
Console.WriteLine("Ваш массив: ");
PrintArray(table);
FindNum(table);


