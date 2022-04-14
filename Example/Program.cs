void PrintMatrix(int[,] matrix)
{
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            Console.Write($"{matrix[i, j]} ");
        }
        Console.WriteLine();
    }
}

int[,] CreateMatrix(int length, int width, int LBound, int RBound)
{
    var matrix = new int[length, width];
    var random = new Random();
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            matrix[i, j] = random.Next(LBound, RBound);
        }
    }
    return matrix;
}

int CountElementInMatrix(int[,] matrix, int element)
{
    int amount = 0;
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            if (matrix[i, j] == element)
                amount++;
        }
    }
    return amount;
}

bool HasMeetElement(int[,] matrix, int element, int row, int column)
{
    for (int i = 0; i < matrix.GetLength(0); i++)

        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            if (i == row && j == column)
                return false;
            if (matrix[i, j] == element)
                return true;
        }
    return false;
}

int CountUniqueElements(int[,] matrix)
{
    int amount = 0;
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            if (HasMeetElement(matrix, matrix[i, j], i, j) == false)
                amount++;
        }
    }
    return amount;
}

int[] GetCountUniqueElements(int[,] matrix)
{
    int[] uniqueElements = new int[CountUniqueElements(matrix)];
    int index = 0;
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            if (HasMeetElement(matrix, matrix[i, j], i, j) == false)
            {
                uniqueElements[index] = matrix[i, j];
                index++;
            }
        }
    }
    return uniqueElements;
}
void PrintArray(int[] array)
{
    for (int i = 0; i < array.Length; i++)
    {
        Console.Write($"{array[i]} ");
    }
    Console.WriteLine();
}

int[,] CountFrequencyElements(int[,] matrix)
{
    int[] uniqueElements = GetCountUniqueElements(matrix);
    PrintArray(uniqueElements);
    int[,] frequencies = new int[uniqueElements.Length, 2];
    for (int i = 0; i < frequencies.GetLength(0); i++)
    {
        frequencies[i, 0] = uniqueElements[i];
        frequencies[i, 1] = CountElementInMatrix(matrix, uniqueElements[i]);

    }
    return frequencies;
}

// int[,] matrix = CreateMatrix(5, 5, 10, 20);
// PrintMatrix(matrix);
// Console.WriteLine();
// var frequencies = CountFrequencyElements(matrix);
// Console.WriteLine();
// PrintMatrix(frequencies);

// Найти произведение двух матриц
int[,] MultiplicationMatrix(int[,] matrix1, int[,] matrix2)
{
    int[,] result = new int[matrix1.GetLength(0), matrix1.GetLength(1)];
    for (int i = 0; i < matrix1.GetLength(0); i++)
    {
        for (int j = 0; j < matrix1.GetLength(1); j++)
        {
            result[i, j] = matrix1[i, j] * matrix2[i, j];
        }
    }
    return result;
}
// В двумерном массиве целых чисел. Удалить строку и столбец, на пересечении которых расположен наименьший элемент.


// Сформировать трехмерный массив не повторяющимися двузначными числами показать его построчно на экран выводя индексы соответствующего элемента


// Показать треугольник Паскаля *Сделать вывод в виде равнобедренного треугольника


// Спирально заполнить двумерный массив:


int[,] array1=CreateMatrix(3,3,0,10);
int[,] array2=CreateMatrix(3,3,0,10);
int[,] array3= MultiplicationMatrix(array1,array2);
Console.WriteLine();
PrintMatrix(array1);
Console.WriteLine();
PrintMatrix(array2);
Console.WriteLine();
PrintMatrix(array3);