int Sumar(int numero)
	=> Enumerable.Range(1, numero - 1).Where(n => n % 3 == 0 || n % 5 == 0).Sum();
Console.WriteLine(Sumar(10));