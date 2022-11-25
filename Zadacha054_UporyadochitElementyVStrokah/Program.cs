// Задайте двумерный массив. Напишите программу, 
// которая упорядочит по убыванию элементы каждой строки двумерного массива.
// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// В итоге получается вот такой массив:
// 7 4 2 1
// 9 5 3 2
// 8 4 4 2

int[,] InputArray()
{ 
    Console.WriteLine("Введите размерность массива :");
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

void PrintArray(int[,] array)
{ 
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            Console.Write($" {array[i,j]} ");
        }
    Console.WriteLine();
    }
}

int[,] array = InputArray();

for (int i = 0; i < array.GetLength(0); i++)
{
    for (int k = array.GetLength(1)-1; k > 0; k--)
    {
        for (int j = 0; j < k; j++)
        {
            if (array[i,j] < array[i,j+1])
            {
                (array[i,j], array[i,j+1]) = (array[i,j+1], array[i,j]);
            }
        }
    }
}

Console.WriteLine("Результат сортировки :");
PrintArray(array);
Console.ReadKey();
