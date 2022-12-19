Console.WriteLine("введите количество строк массива: ");
int rows = int.Parse(Console.ReadLine()!);

Console.WriteLine("введите количество столбцов массива: ");
int colums = int.Parse(Console.ReadLine()!);

int[,] matrix = GetArray(rows, colums, 0, 9);
PrintArray(matrix);
Console.WriteLine("Введите элемент: ");
int element=int.Parse(Console.ReadLine()!);
if(FindElement(matrix, element))
{
  Console.WriteLine("Элемент найден");
}
else 
{
  Console.WriteLine("Элемент не найден");
}

int [,] GetArray(int m, int n, int minvalue, int maxvalue)
{
    int [,] result = new int [m, n];
    for (int i=0; i<m; i++)
    {
        for (int j=0; j<n; j++)
        {
            
            result[i,j] = new Random().Next(minvalue, maxvalue+1);
        }
    }
    return result;
}

void PrintArray(int[,] array)
{
    for (int i=0; i<array.GetLength(0); i++)
    {
        for (int j=0; j<array.GetLength(1); j++)
        {
            Console.Write($"{array[i,j]} ");
        }
        Console.WriteLine();
    }
}

bool FindElement(int [,] array, int element)
{
  for(int i=0; i<array.GetLength(0); i++)
  {
    for(int j=0; j<array.GetLength(1); j++)
    {
      if(array[i,j]==element)
      {
        return true;
      }
    }
  }
  return false;
}