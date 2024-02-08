System.Console.WriteLine("Введите любое двухзначное число");
string stringNum = Console.ReadLine();
int intNum = Convert.ToInt32(stringNum);
// System.Console.WriteLine("Вы ввели число " + intNum);
if (intNum<10 && intNum>99)
{
    Console.WriteLine("Повторите попытку");
}
else
{
    int a = intNum/10;
    int b = intNum%10;
    if (a==b)
    {
        Console.WriteLine($"Цыфры в числе {intNum} равны между собой");
    }
    else if (a>b)
    {
        Console.WriteLine($"Наибольшая цифра в числе {intNum}: {a}");
    }
        else
    {
        Console.WriteLine($"Наибольшая цифра в числе {intNum}: {b}");
    }
}