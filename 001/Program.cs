// Написать программу, упорядочивания по убыванию элементы каждой строки двумерной массива.
Console.WriteLine("Задайте число равное количеству строк двумерного массива");
int m = int.Parse(Console.ReadLine()!);
Console.WriteLine("Задайте число равное количеству столбцов двумерного массива");
int n = int.Parse(Console.ReadLine()!);
void Printmatr(int[,] matr)
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

void Fillmatr(int[,] matr)
{
    for (int i = 0; i < matr.GetLength(0); i++) 
    {
        for (int j = 0; j < matr.GetLength(1); j++) 
        {
            matr[i,j] = new Random().Next(1,10); 
        }
    }
    
}

void StringSortingArray(int[,] matr)
{
    for (int i = 0; i < matr.GetLength(0); i++)
    {
        for (int j = 0; j < matr.GetLength(1); j++)
        {
            int minPosition = j; 
            for (int k = j + 1; k < matr.GetLength(1); k++) 
            {
                if (matr[i, k] > matr[i, minPosition]) 
                {
                    minPosition = k;
                } 
            }
            int tmp = matr[i, j]; 
            matr[i, j] = matr[i, minPosition]; 
            matr[i, minPosition] = tmp; 
            Console.Write(matr[i, j] + " ");
        }
        Console.WriteLine();
    }
}


int[,] matrix = new int[m, n];
Fillmatr(matrix);
Console.WriteLine();
Printmatr(matrix);
Console.WriteLine();
Console.WriteLine("Сортировка строк двумерного массива по убыванию");
StringSortingArray(matrix);
