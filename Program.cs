void From1ToN(int n)
{
    for (int i = 2; i <= n; i += 2)
        Console.WriteLine(i + ", ");
}

int n = 5;
From1ToN(n);

n = 7;
From1ToN(n);