System.Console.WriteLine("Введите координаты точки по оси X:");
string stringX = Console.ReadLine();
int intX = Convert.ToInt32(stringX);
System.Console.WriteLine("Введите координаты точки по оси Y:");
string stringY = Console.ReadLine();
int intY = Convert.ToInt32(stringY);
System.Console.WriteLine($"Вы ввели координаты точки ({intX}, {intY})");
if (intX > 0 && intY > 0)
{
    Console.WriteLine($"Точка с координатами ({intX}, {intY}) находится в первой четверти.");
}
else if (intX < 0 && intY > 0)
{
    Console.WriteLine($"Точка с координатами ({intX}, {intY}) находится во второй четверти.");
}
else if (intX < 0 && intY < 0)
{
    Console.WriteLine($"Точка с координатами ({intX}, {intY}) находится в третьей четверти.");
}
else if (intX > 0 && intY < 0)
{
    Console.WriteLine($"Точка с координатами ({intX}, {intY}) находится в четвёртой четверти.");
}
else
{
    Console.WriteLine($"Точка с координатами ({intX}, {intY}) находится в начале координат.");
}