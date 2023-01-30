/*
Задача 54: Задайте двумерный массив. Напишите программу, которая упорядочит по убыванию элементы каждой строки двумерного массива.
Например, задан массив:
1 4 7 2
5 9 2 3
8 4 2 4
В итоге получается вот такой массив:
7 4 2 1
9 5 3 2
8 4 4 2
*/


void InputMatrix(int[,] matrix) {
    for (int i = 0; i < matrix.GetLength(0); i++){
        for (int j = 0; j < matrix.GetLength(1); j++){
            matrix[i, j] = new Random().Next(1, 11); // [1, 10]
        }
    }
    PrintMatrix(matrix);
}

void PrintMatrix (int[,] matrix){
    for (int i = 0; i < matrix.GetLength(0); i++){
        for (int j = 0; j < matrix.GetLength(1); j++){
            Console.Write($"{matrix[i, j]} \t");
        }
        Console.WriteLine();
    }
}

void Release(int[,] matrix){
    int temp = 0;
    for (int i = 0; i < matrix.GetLength(0); i++){
        for (int write = 0; write < matrix.GetLength(1); write++) { 
        for (int j = 0; j < matrix.GetLength(1) -1; j++){
            if (matrix [i,j] > matrix[i,j+1]){
                temp = matrix[i,j+1];
                matrix[i,j+1] = matrix[i,j];
                matrix[i,j] = temp;
            }
        } 
        }
    }
    PrintMatrix(matrix);
}

Console.Clear();

Console.WriteLine("Введите размер массива через пробел:");
int[] size = Console.ReadLine().Split(" ").Select(x => int.Parse(x)).ToArray();
int [,] matrix = new int[size[0],size[1]];

Console.WriteLine("Массив:");
InputMatrix(matrix);
Console.WriteLine("Массив отсортированный:");
Release(matrix); 
