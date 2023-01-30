/*
Задача 62. Напишите программу, которая заполнит спирально массив 4 на 4.
Например, на выходе получается вот такой массив:
01 02 03 04
12 13 14 05
11 16 15 06
10 09 08 07


00 01 02 03
10 11 12 13
20 21 22 23
30 31 32 33
*/
Console.Clear();
int n=0, m =0;
int[,] matrix = new int[4,4];
int i =0, j=0;
int flag =0;
for (int k=1; k < 17;k++){
    i= i+n;
    j= j+m; 
    if (j != 0 && matrix[i,j-1] == 0 && flag == 1){ //up
        n = 0;
        m = -1;
    }
    else if (i < 3 && matrix[i+1,j] == 0){ //right
        n = 1;
        m = 0;
    }
    else if (j < 3 && matrix[i,j+1] == 0) { //down
        n = 0;
        m = 1;
    }
    else if (i !=0 && matrix[i-1,j] == 0){ //left
        n = -1;
        m = 0;
        if (i == 1) flag = 1;
    }
       matrix[i, j] = k;
        }
    for (int l = 0; l < matrix.GetLength(0); l++){
        for (int p = 0; p < matrix.GetLength(1); p++){
            Console.Write($"{matrix[p, l]} \t");
        }
        Console.WriteLine();
}
