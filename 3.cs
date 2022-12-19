Console.WriteLine("введите количество строк массива: ");
int rows = int.Parse(Console.ReadLine()!);

Console.WriteLine("введите количество столбцов массива: ");
int colums = int.Parse(Console.ReadLine()!);

int[,] matrix = GetArray(rows, colums, 0, 10);
PrintArray(matrix);
Console.WriteLine();
double[] avg =GetAverage(matrix);
Console.WriteLine($"{String.Join("; ",avg)}");


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

double[] GetAverage(int[,] array)
{
    double[] result = new double[array.GetLength(1)];
    for(int i=0; i<array.GetLength(1); i++)
    {
        double sum =0;
        for(int j=0; j<array.GetLength(0); j++)
        {
            sum+=array[j,i];
        }
        result[i]=Math.Round(sum/array.GetLength(0),2);
    }
    return result;
}
