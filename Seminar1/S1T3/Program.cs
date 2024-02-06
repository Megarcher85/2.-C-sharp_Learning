System.Console.WriteLine("Введите трёхзначное число:");
int N = int.Parse(Console.ReadLine());
if (N < 0)
{
    N = -N;
}
int a = N / 100;
int b = N % 10;
int c = a + b;
System.Console.Write("Сумма первой и последней цифры числа ");
System.Console.Write(N);
System.Console.Write(" равна: ");
System.Console.Write(c);
Console.ReadKey();