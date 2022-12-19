Console.WriteLine("введите количество строк массива: ");
int rows = int.Parse(Console.ReadLine()!);

Console.WriteLine("введите количество столбцов массива: ");
int colums = int.Parse(Console.ReadLine()!);

double[,] matrix = GetArray(rows, colums, 0, 100);
PrintArray(matrix);
Console.WriteLine();


double[,] GetArray(int m, int n, int minvalue, int maxvalue)
{
  double[,] result = new double [m, n];
  for (int i=0; i<m; i++)
  {
    for (int j=0; j<n; j++)
    {
      result[i,j] = new Random().NextDouble()*(maxvalue-minvalue);
    }
  }
  return result;
}

void PrintArray(double[,] array)
{
  for (int i=0; i<array.GetLength(0); i++)
  {
    for (int j=0; j<array.GetLength(1); j++)
    {
      Console.Write($"{Math.Round(array[i,j],1)} ");
    }
    Console.WriteLine();
  }
}

