/*
Задача 58: Задайте две матрицы. Напишите программу, которая будет находить произведение двух матриц.
Например, даны 2 матрицы:
2 4 | 3 4
3 2 | 3 3
Результирующая матрица будет:
6 16
9 6
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
    Console.WriteLine();
}

void Release(int[,] matrix1, int[,] matrix2,int [,] matrixPow){
    for (int i = 0; i < matrix1.GetLength(0); i++){
        for (int j = 0; j < matrix1.GetLength(1); j++){
            matrixPow [i,j]= matrix1[i,j] * matrix2[i,j];
        }
    }
    PrintMatrix(matrixPow);
}

Console.Clear();

Console.WriteLine("Введите размер массива через пробел:");
int[] size = Console.ReadLine().Split(" ").Select(x => int.Parse(x)).ToArray();
int [,] matrixFirst = new int[size[0],size[1]];
int [,] matrixSecond = new int[size[0],size[1]];
int [,] matrixPow = new int[size[0],size[1]];

Console.WriteLine("Массив:");
InputMatrix(matrixFirst);
InputMatrix(matrixSecond);
Console.WriteLine("Массив перемноженный:");
Release(matrixFirst,matrixSecond,matrixPow); 

