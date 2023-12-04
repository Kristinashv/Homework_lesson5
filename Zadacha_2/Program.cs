// Zadacha

int n = 10;
int m = 10;
int[,] arr = new int [n,m];
Random rand = new Random();
Console.WriteLine("Массив случайных чисел 1 : ");
for(int i = 0; i < n ; i++)
{
    for(int j = 0; j < m ; j++)
    {
        arr[i,j] = rand.Next(10,100);
        Console.Write(arr[i,j]+" ");
    }
    Console.WriteLine();
}
for(int j = 0; j < m ; j++)
{
    int k = arr[0,j];
    arr[0,j] = arr[n-1,j];
    arr[n-1,j] = k;
}
Console.WriteLine();
Console.WriteLine("Массив случайных чисел 2 : ");
for(int i = 0; i < n ; i++)
{
    for(int j = 0; j < m ; j++)
    {
        Console.Write(arr[i,j]+" ");
    }
    Console.WriteLine();
}

