// Enter two natural numbers M and N. Write program, which outputs all natural numbers in range [M,N]

string NumbersInRange(int m, int n)
{
    string str = Convert.ToString(m);
    if (m == n)
        return str + ".";
    else
        return str + ", " + Convert.ToString(NumbersInRange(m + 1, n));
}

Console.WriteLine("Enter the first natural number M: ");
int m = int.Parse(Console.ReadLine());
Console.WriteLine("Enter the second natural number N: ");
int n = int.Parse(Console.ReadLine());

Console.WriteLine(NumbersInRange(m, n));
