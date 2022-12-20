// Задача 47. Задайте двумерный массив размером m×n, заполненный случайными вещественными числами.

// m = 3, n = 4.

// 0,5 7 -2 -0,2
// 1 -3,3 8 -9,9
// 8 7,8 -7,1 9

int m = 3, n = 5;
double[,] myArray = new double [m,n];
Random rand = new Random();
for (int i = 0; i < m; i++)
{
    for (int j = 0; j < n; j++)
    {
        myArray[i,j] = rand.Next(1,100) + rand.NextDouble();
        Console.Write("{0}\t", myArray[i,j]);
    }

    Console.WriteLine();
}