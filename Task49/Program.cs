// Задача 49: Задайте двумерный массив. 
// Найдите элементы, у которых оба индекса чётные, 
// и замените эти элементы на их квадраты.

Console.WriteLine("Type the number of rows: ");
int row = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("Type the number of columns: ");
int col = Convert.ToInt32(Console.ReadLine());

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

Console.WriteLine("New matrix: ");
 
 for (int i = 0; i < matrix.GetLength(0); i++)
 {
    for (int j = 0; j < matrix.GetLength(1); j++)
    {
        if(i%2==0 && j%2==0)
    {
        matrix[i,j]*=matrix[i,j];
    }
    Console.Write(matrix[i,j]+" ");
    }

    Console.WriteLine();
 }


