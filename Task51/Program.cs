// Задача 51: Задайте двумерный массив. 
// Найдите сумму элементов, находящихся на главной диагонали 
// (с индексами (0,0); (1;1) и т.д.
// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// Сумма элементов главной диагонали: 1+9+2 = 12

Console.WriteLine("Type the number of rows: ");
int row = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("Type the number of columns: ");
int col = Convert.ToInt32(Console.ReadLine());

int sum = 0;

 int[,] matrix = new int[row, col];


 for (int i = 0; i < matrix.GetLength(0); i++)
 {
    for (int j = 0; j < matrix.GetLength(1); j++)
    {
        matrix[i,j] = i+j;
        Console.Write(matrix[i,j]+" ");
    }
Console.WriteLine();
 }

for (int i = 0; i < matrix.GetLength(0); i++)
{
    for (int j = 0; j < matrix.GetLength(1); j++)
    {
        if (i==j)
        {
            sum= sum+matrix[i,j];

        }
    }
    
}
Console.WriteLine(sum);