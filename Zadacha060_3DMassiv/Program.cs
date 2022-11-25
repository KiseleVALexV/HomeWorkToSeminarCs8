﻿// ...Сформируйте трёхмерный массив из неповторяющихся двузначных чисел.
// Напишите программу, которая будет построчно выводить массив,
// добавляя индексы каждого элемента.
// Массив размером 2 x 2 x 2
// 66(0,0,0) 25(0,1,0)
// 34(1,0,0) 41(1,1,0)
// 27(0,0,1) 90(0,1,1)
// 26(1,0,1) 55(1,1,1)

int[,,] InputArray()
{ 
    Console.WriteLine("Введите размерность массива :");
    int m = Convert.ToInt32(Console.ReadLine());
    int n = Convert.ToInt32(Console.ReadLine());
    int p = Convert.ToInt32(Console.ReadLine());
    int[,,] array = new int[m, n, p];
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            for (int k = 0; k < array.GetLength(2); k++)
            {
                array[i,j,k] = new Random().Next(0,100); 
                Console.Write($" {array[i,j,k]}({i},{j},{k}) ");
            }
        }
        Console.WriteLine();
    }
    return array;
}

InputArray();

Console.ReadKey();
