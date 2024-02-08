// ЗАДАЧА 1
System.Console.WriteLine("Введите любое число");
string stringNum = Console.ReadLine();
int intNum = Convert.ToInt32(stringNum);
// System.Console.WriteLine("Вы ввели число " + intNum);
if (intNum%7==0 && intNum%23==0)
{
    System.Console.WriteLine($"Число {intNum} кратно число 7 и 23.");
}
else
{
    System.Console.WriteLine($"Число {intNum} не кратно число 7 и 23.");
}