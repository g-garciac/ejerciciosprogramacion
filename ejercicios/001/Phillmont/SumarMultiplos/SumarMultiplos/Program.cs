int Sumar(int Limite)
{
    int Suma = 0;
    for (int i = 1; i <= Limite; i++)
    {
        if (i % 3 == 0)
            Suma += i;
        else if (i % 5 == 0)
            Suma += i;
    }
    return Suma;
}

Console.WriteLine(Sumar(10));