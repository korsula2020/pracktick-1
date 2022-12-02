int NumberA = 2;
int NumberB = 3;
int NumberC = 7;
if (NumberA < NumberB)
{
    if (NumberB < NumberC)
    {
        Console.WriteLine(NumberC);
    }
    if (NumberB > NumberC)
    {
        Console.WriteLine(NumberB);
    }
    if (NumberB == NumberC)
    {
        Console.WriteLine("числа равные");
    }
}
if (NumberA == NumberB)
{
    if (NumberB > NumberC)
    {
        Console.WriteLine(NumberB);
    }
    if (NumberB < NumberC)
    {
        Console.WriteLine(NumberC);
    }
    if (NumberB == NumberC )
    {
        Console.WriteLine("числа равные");
    }
}
if (NumberA > NumberB)
{
    if (NumberA < NumberC)
    {
        Console.WriteLine(NumberC);
    }
    if (NumberA > NumberC)
    {
        Console.WriteLine(NumberA);
    }
    if (NumberA == NumberC )
    {
        Console.WriteLine("числа равные");
    }
}