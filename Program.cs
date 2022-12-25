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

// double rows, cols,sumCol;
// double resultCol;

// //Initialize matrix a  
// int[,] a = {
//     {1, 4, 7, 2},
//     {5, 9, 2, 3},
//     {8, 4, 2, 4}
// };

// //Calculates number of rows and columns present in given matrix  
// rows = a.GetLength(0);
// cols = a.GetLength(1);

// //Calculates sum of each column of given matrix  
// for (int i = 0; i < cols; i++)
// {
//     sumCol = 0;
//     for (int j = 0; j < rows; j++)
//     {
//         sumCol = sumCol + a[j, i];
//     }
//     resultCol = sumCol / rows;
//     Console.WriteLine("Sum of " + (i + 1) + " column: " + sumCol + " " + Math.Round(resultCol,1));
// }