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

// Задача 50. Напишите программу, которая на вход принимает позиции элемента в двумерном массиве, и возвращает значение этого элемента или же указание, что такого элемента нет.

// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// 17 -> такого числа в массиве нет

// Console.WriteLine("Введите номер элемента строки");
// int rowPos = Convert.ToInt32(Console.ReadLine());
// Console.WriteLine("Введите номер элемента столбца");
// int colPos = Convert.ToInt32(Console.ReadLine());

// int rows, cols;
// bool result1 = false;
// bool result2 = false;

// //Initialize matrix a  
// int[,] a = {
//     {1, 4, 7, 2},
//     {5, 9, 2, 3},
//     {8, 4, 2, 4}
// };

// rows = a.GetLength(0);
// cols = a.GetLength(1);

// for (int i = 0; i < rows; i++)
// {
//     for (int j = 0; j < cols; j++)
//     {
//         if (j == colPos)
//         {
//             result1 = true;
//         } 
//     } 
//     if (i == rowPos)
//     {
//         result2 = true;
//     } 
// }
// if (result1 && result2 == true)
// {
//     Console.WriteLine($"{rowPos}{colPos} элемент с такой позицией в массиве есть, это число {a[rowPos,colPos]}");
// } else Console.WriteLine($"{rowPos}{colPos} элемента с такой позицией в массиве нет");