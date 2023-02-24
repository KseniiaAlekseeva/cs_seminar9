// Program output all natural numbers from 1 to N

void PrintNumbers(int n, int start)
{
    Console.Write(start + ", ");
    if (start == n)
        return;
    else
        PrintNumbers(n, start + 1);
}

Console.WriteLine("Enter the natural number: ");
int n = int.Parse(Console.ReadLine());

PrintNumbers(n, 1);