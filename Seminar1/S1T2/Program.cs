int N = -4;
if (N < 0)
{
    N = -N;
}
int i = -N;
while (i < N)
{
    System.Console.Write(i);
    System.Console.Write(", ");
    i += 1;
}
System.Console.Write(i);