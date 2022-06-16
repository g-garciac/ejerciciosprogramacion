int SumarSerie(int n)
{
    int pv = 1;
    int sv = 1;
    int suma = 0;
    for (int a = 2; a <= n; a++)
    {
        int x = pv + sv;
        if (x % 2 == 0)
            suma += x;
        pv = sv;
        sv = x;
    }
    return suma;
}

Console.WriteLine(SumarSerie(20));