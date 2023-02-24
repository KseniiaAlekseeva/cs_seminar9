// Program, which raises number A to the power B by recursion.

int Pow(int a, int b)
{
    if (b == 1)
        return a;
    else
        return a * Pow(a, b - 1);
}

Console.WriteLine("Enter the foundation A in A^B: ");
int a = int.Parse(Console.ReadLine());
Console.WriteLine("Enter the degree B in A^B: ");
int b = int.Parse(Console.ReadLine());

Console.WriteLine($"{a}^{b} = {Pow(a, b)}.");
