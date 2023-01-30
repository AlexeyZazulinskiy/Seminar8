/*
Задача 60. ...Сформируйте трёхмерный массив из неповторяющихся двузначных чисел. Напишите программу, которая будет построчно выводить массив, добавляя индексы каждого элемента.
Массив размером 2 x 2 x 2
66(0,0,0) 25(0,1,0)
34(1,0,0) 41(1,1,0)
27(0,0,1) 90(0,1,1)
26(1,0,1) 55(1,1,1)
*/

void FillMatrix(int[,,] matrix, int[] number){
                int count =0;

    for (int i = 0; i < matrix.GetLength(0); i++){
        for (int j = 0; j < matrix.GetLength(1); j++){
            for (int k = 0; k < matrix.GetLength(2); k++){

            matrix[i, j, k] = RestMatrix(matrix[i,j,k],number, count);
            count++;           
            }
        }
    }
}

int RestMatrix (int matrix, int[] number, int count){
    matrix = new Random().Next(10, 100);
    for (int j = 0; j < number.Length; j++){                 
        if (matrix == number[j]) {
            matrix++;
            j = 0;
        }
            if (matrix == 20){ 
                matrix = 10;
                j = 0;
            }
    } 
    number[count] = matrix;                     
    return matrix;

}

void PrintMatrix(int[,,] matrix){
    for (int i = 0; i < matrix.GetLength(0); i++){
        for (int j = 0; j < matrix.GetLength(1); j++){
            for (int k = 0; k < matrix.GetLength(2); k++){
            Console.Write($"{matrix[i, j,k]}({i},{j},{k}) \t");
            }
        }
        Console.WriteLine(); 
    }
    Console.WriteLine();
}

int i= 2, j= 2, k= 2;
int[,,] matrix = new int [i, j, k];
int[]   number = new int [i* j* k];

Console.Clear();
FillMatrix(matrix,number);
PrintMatrix(matrix);