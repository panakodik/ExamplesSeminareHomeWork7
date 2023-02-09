// В прямоугольной матрице найти строку с наименьшей суммой элементов.

Console.Clear();

Console.WriteLine("Введите размер двумерного массива m x n: ");
Console.Write("Задайте количество строк m = ");
int m = int.Parse(Console.ReadLine());
Console.Write("Задайте количество столбцов n = ");
int n = int.Parse(Console.ReadLine()); 
int[,] matr = new int[m, n];

Console.WriteLine();
FillArray();
Console.WriteLine();
SumColumnArray();
Console.WriteLine();


void FillArray()
{            
for (int i = 0; i < matr.GetLength(0); i++)
{
    for (int j = 0; j < matr.GetLength(1); j++)
    {
        matr[i,j] = new Random().Next(1,10); // [1; 10)
        Console.Write("{0, 5}", (matr[i, j]).ToString("0"));
    }
Console.WriteLine();
}
}

void SumColumnArray()
{    
    int[] array = new int[matr.GetLength(0)];       
    int sumRows = 0;
    int rows = 0;
    int minRows = array[0];
    int indexMin = 0;
for (int i = 0; i < matr.GetLength(0); i++)
{

    for (int j = 0; j < matr.GetLength(1); j++)
    {
        sumRows = sumRows + matr[i,j];
    }
    array[i] = sumRows;
    rows++;
    Console.WriteLine("Сумма элементов " + rows + "-ой строки " + sumRows);
    sumRows = 0;
}
Console.WriteLine();
//Console.WriteLine("{0}", string.Join("; ", array));
MinSum();
void MinSum()
{
    int minCol = array[0];
    int indexMin = 0;
    for (int i = 1; i < matr.GetLength(0); i++)
    {
        if(array[i] < minCol)
        {
            minCol = array[i];
            indexMin = i;
        }
    }
    Console.WriteLine("Строка с наименьшей суммой элементов под № " + (indexMin + 1));
}
}