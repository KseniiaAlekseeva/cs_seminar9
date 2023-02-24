// Program outputs the sum of digits of entered integer number.

int SumDigits(int n)
{
    if (n / 10 == 0)
        return n;
    else
        return n % 10 + SumDigits(n / 10);
}

Console.WriteLine("Enter the first natural number M: ");
int n = int.Parse(Console.ReadLine());

Console.WriteLine($"The sum of digits of number {n} is {SumDigits(n)}.");