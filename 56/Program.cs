/*
Задача 56: Задайте прямоугольный двумерный массив. Напишите программу, которая будет находить строку с наименьшей суммой элементов.
Например, задан массив:

1 4 7 2
5 9 2 3
8 4 2 4
5 2 6 7
Программа считает сумму элементов в каждой строке и выдаёт номер строки с наименьшей суммой элементов: 1 строка
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

void SumRow(int[,] matrix, int[] arrayRow){
  
    for (int i = 0; i < matrix.GetLength(0); i++){
    int sum = 0;          
        for (int j = 0; j <= matrix.GetLength(1) -1; j++){
            sum += matrix[i,j];
            }
        arrayRow[i] = sum; 
         }
}

int MaxRow(int[] arrayRow){
    int min =arrayRow[0];
    int count = 0;

    for (int i=0; i < arrayRow.Length; i++){
        if (arrayRow[i] < min) {
            min = arrayRow[i];
            count = i;         
        }
    } return count+1;
}

Console.Clear();

Console.WriteLine("Введите размер массива через пробел:");
int[] size = Console.ReadLine().Split(" ").Select(x => int.Parse(x)).ToArray();
int [,] matrix = new int[size[0],size[1]];
int[] arrayRow = new int[size[0]];

Console.WriteLine("Массивы:");
InputMatrix(matrix);
SumRow(matrix, arrayRow);

Console.WriteLine($"Строка с наименьшей суммой элементов:{MaxRow(arrayRow)}");
