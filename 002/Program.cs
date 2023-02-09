// Написать программу, которая в двумерном массиве заменяет строки на столбцы 
//или сообщить, что это невозможно (в случае, если матрица не квадратная).
Console.WriteLine("Задайте число равное количеству строк двумерного массива");
int m = int.Parse(Console.ReadLine()!);
Console.WriteLine("Задайте число равное количеству столбцов двумерного массива");
int n = int.Parse(Console.ReadLine()!);
void PrintArray(int[,] matr)
{
    for (int i = 0; i < matr.GetLength(0); i++) 
    {
        for (int j = 0; j < matr.GetLength(1); j++) 
        {
            Console.Write($"{matr[i, j]} ");
        }
        Console.WriteLine();
    }
}

void FillArray(int[,] matr)
{
    for (int i = 0; i < matr.GetLength(0); i++) 
    {
        for (int j = 0; j < matr.GetLength(1); j++) 
        {
            matr[i,j] = new Random().Next(1,10); 
        }
    }
    
}

void ReplacementArray(int[,] matr)
{
  for(int i=0; i< matr.GetLength(0); i++) 
  {
    for(int j=i+1; j < matr.GetLength(1); j++) 
    {
        int temp = matr[i, j];
        matr[i, j] = matr[j, i];
        matr[j, i] = temp;
    }
  }
}

int[,] matrix = new int[m, n];
FillArray(matrix);
Console.WriteLine();
PrintArray(matrix);
Console.WriteLine();
if (matrix.GetLength(0) == matrix.GetLength(1))
{
    ReplacementArray(matrix);
    Console.WriteLine("Замена строк на столбцы");
    PrintArray(matrix);
}
else 
Console.WriteLine("Данную матрицу транспонировать невозможно!");

