// ЗАДАЧА 4
System.Console.WriteLine("Введите любое число");
string stringNum = Console.ReadLine();
int intNum = Convert.ToInt32(stringNum);
int a = intNum;
double b = intNum;
int Num = 1;
int i = 0;
while (Num > 0)
{
    Num = a / 10;
    i += 1;
    a = Num;
}
System.Console.WriteLine($"Количество цифр в числе {intNum} равно {i}");
double c = 0;
for (int j = i - 1; j >= 0; j--)
{
    c = b / (Math.Pow(10, j));
    double ost = b % (Math.Pow(10, j));
    b = ost;
    int d = (int)c;
    if (ost > 0)
    {
        Console.Write($"{d}, ");
    }
    else
    {
        Console.Write(d);
    }
}