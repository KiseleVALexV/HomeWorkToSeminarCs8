// Задайте две матрицы. Напишите программу, 
// которая будет находить произведение двух матриц.
// Например, даны 2 матрицы:
// 2 4 | 3 4
// 3 2 | 3 3
// Результирующая матрица будет:
// 18 20
// 15 18

int[,] InputArray(int x)
{ 
    Console.WriteLine($"Введите размерность массива {x} :");
    int m = Convert.ToInt32(Console.ReadLine());
    int n = Convert.ToInt32(Console.ReadLine());
    int[,] array = new int[m, n];
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            array[i,j] = new Random().Next(0,10); 
            Console.Write($" {array[i,j]} ");
        }
        Console.WriteLine();
    }
    return array;
}

int[,] MatrixProduct(int[,] a, int[,] b)
{
    int[,] c = new int [a.GetLength(0), b.GetLength(1)];
    for (int i = 0; i < a.GetLength(0); i++)
    {
        for (int j = 0; j < b.GetLength(1); j++)
        {
            int temp = 0;
            for (int k = 0; k < a.GetLength(1); k++)
            {
                temp += a[i,k]*b[k,j];
            }
            c[i,j] = temp;
        }
    }
    return c;
}

void CheckSize(int[,] a, int[,] b)
{
    if (a.GetLength(0) != b.GetLength(1))
    {
        Console.WriteLine("Матрицы не согласованы");
    }
    else 
    {
        PrintArray(MatrixProduct(a, b));
    }
}

void PrintArray(int[,] array)
{ 
    Console.WriteLine("Результат произведения матриц :");
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            Console.Write($" {array[i,j]} ");
        }
    Console.WriteLine();
    }
}

int[,] a = InputArray(1);
int[,] b = InputArray(2);
CheckSize(a,b);

Console.ReadKey();
