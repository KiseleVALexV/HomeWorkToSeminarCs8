// Задайте прямоугольный двумерный массив.
// Напишите программу, которая будет находить строку с наименьшей суммой элементов.
// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// 5 2 6 7
// Программа считает сумму элементов в каждой строке
// и выдаёт номер строки с наименьшей суммой элементов: 1 строка

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

void SearchMini(int[,] array)
{
    int mini = 0;
    int row = 1;
    for (int i = 0; i < array.GetLength(0); i++)
    {
        int sum = 0;
        for (int j = 0; j < array.GetLength(1); j++)
        {
            sum += array[i,j];
        }
        if (sum < mini)
        {
            mini = sum;
            row = i+1;
        }
    }
    Console.WriteLine($"Строка с наименьшей суммой элементов :{row}");
}

SearchMini(InputArray());
Console.ReadKey();
