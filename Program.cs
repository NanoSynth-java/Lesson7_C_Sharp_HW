// Задача 47. Задайте двумерный массив размером m×n, заполненный случайными вещественными числами.

// m = 3, n = 4.

// 0,5 7 -2 -0,2
// 1 -3,3 8 -9,9
// 8 7,8 -7,1 9


// int m = 3, n = 4;
// double[,] myArray = new double [m,n];
// Random rand = new Random();
// for (int i = 0; i < m; i++)
// {
//     for (int j = 0; j < n; j++)
//     {
//         myArray[i,j] = rand.Next(1,100) + rand.NextDouble();
//         Console.Write("{0}\t", myArray[i,j]);
//     }

//     Console.WriteLine();
// }



// Задача 52. Задайте двумерный массив из целых чисел. Найдите среднее арифметическое элементов в каждом столбце.

// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// Среднее арифметическое каждого столбца: 4,6; 5,6; 3,6; 3.

int stroka = 4;
int stolb = 4;
int sum = 0;
int[,] myArray = new int[stroka, stolb];
Random rand = new Random();
for (int j = 0; j < stroka; j++)
{
    for (int i = 0; i < stolb; i++)
    {
        myArray[i, j] = rand.Next(1, 10);
        sum = sum + myArray[i,j];
        Console.Write("{0}\t", myArray[i, j]);
    }
    Console.WriteLine();
    Console.WriteLine(String.Format("Summation of {0}th column is {1}", j,sum)); 
    sum = 0;
}