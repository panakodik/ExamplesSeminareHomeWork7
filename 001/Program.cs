// Написать программу, упорядочивания по убыванию элементы каждой строки двумерной массива.
Console.WriteLine("Задайте число равное количеству строк двумерного массива");
int m = int.Parse(Console.ReadLine()!);
Console.WriteLine("Задайте число равное количеству столбцов двумерного массива");
int n = int.Parse(Console.ReadLine()!);
void PrintArray(int[,] matr)
{
    for (int i = 0; i < matr.GetLength(0); i++) // matrix.GetLength(0) это нулевой элемент массива [3, 4] т.е. 3.
    {
        for (int j = 0; j < matr.GetLength(1); j++) // matrix.GetLength(1) это первый элемент массива [3, 4] т.е. 4.
        {
            Console.Write($"{matr[i, j]} ");
        }
        Console.WriteLine();
    }
}

void FillArray(int[,] matr)
{
    for (int i = 0; i < matr.GetLength(0); i++) // matrix.GetLength(0) это нулевой элемент массива [3, 4] т.е. 3.
    {
        for (int j = 0; j < matr.GetLength(1); j++) // matrix.GetLength(1) это первый элемент массива [3, 4] т.е. 4.
        {
            matr[i,j] = new Random().Next(1,10); // [1; 10)
        }
    }
    
}

void StringSortingArray(int[,] matr)
{
  for (int i = 0; i < matr.GetLength(0); i++)
  {
    for (int j = 0; j < matr.GetLength(1); j++)
    {
      for (int k = 0; k < matr.GetLength(1) - 1; k++)
      {
        if (matr[i, k] < matr[i, k + 1])
        {
          int temp = matr[i, k + 1];
          matr[i, k + 1] = matr[i, k];
          matr[i, k] = temp;
        }
      }
    Console.Write(matr[i, j] + " ");
    }
    Console.WriteLine();
  }
}
int[,] matrix = new int[m, n];
FillArray(matrix);
Console.WriteLine();
PrintArray(matrix);
Console.WriteLine();
Console.WriteLine("Сортировка строк двумерного массива по убыванию");
//Console.WriteLine();
StringSortingArray(matrix);

/*Console.WriteLine();
PrintArray(matrix);*/