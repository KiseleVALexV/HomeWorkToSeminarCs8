// Напишите программу, которая заполнит спирально массив 4 на 4.
// Например, на выходе получается вот такой массив:
// 01 02 03 04
// 12 13 14 05
// 11 16 15 06
// 10 09 08 07

int[,] InputArray(int m, int n)
{
    int[,] array = new int[m, n];
    int mean = 1;
    int rs = 0;
    int re = array.GetLength(0);
    int cs = 0;
    int ce = array.GetLength(1);
    while (rs < re && cs < ce)
    {
        for (int i = cs; i < ce; ++i)
        {
            array[rs,i] = mean++;
        }
        rs++; 
        for (int i = rs; i < re; ++i)
        {
            array[i,ce-1] = mean++;
        }
        ce--;
        if (rs < re)
        {
            for (int i = ce-1; i >= cs; --i)
            {
                array[re-1,i] = mean++;
            }
            re--;
        }
        if (cs < ce)
        {
            for (int i = re-1; i >= rs; --i)
            {
                array[i,cs] = mean++;
            }
            cs++;
        }
    }
    return array;
}

void PrintArray(int[,] array)
{ 
    Console.WriteLine("Результат произведения матриц :");
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            Console.Write($" {array[i,j]:D2} ");
        }
    Console.WriteLine();
    }
}

PrintArray(InputArray(4,4));

Console.ReadKey();
