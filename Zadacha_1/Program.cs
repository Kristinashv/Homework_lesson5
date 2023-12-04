// Zadacha 1

class HelloWorld {
  static void Main() {
    int n = 10;
    int m = 10;
    int[,] arr = new int [n,m];
    Random rand = new Random();
    Console.Write("Массив случайных чисел : ");
    Console.WriteLine();
    for(int i = 0; i < n ; i++)
    {
        for(int j = 0; j < m ; j++)
        {
            arr[i,j] = rand.Next(10,100);
            Console.Write(arr[i,j]+" ");
        }
        Console.WriteLine();
    }
    int a , b;
    do
    {
        Console.WriteLine("Введите координаты элемента : ");
        a = Convert.ToInt32(Console.ReadLine());
        b = Convert.ToInt32(Console.ReadLine());
        fun(a,b,arr);
    }while((a>arr.GetLength(0))||(b>arr.GetLength(1)));
  }
  static void fun(int a , int b , int[,]arr)
  {
    if((a<=arr.GetLength(0))&&(b<=arr.GetLength(1)))
    {
        Console.WriteLine("Элемент равен = "+ arr[a-1,b-1]);
    }
    else
    {
        Console.WriteLine("Значение выходит за массив");
    }
  }
}