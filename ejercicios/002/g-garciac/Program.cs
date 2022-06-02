int Fibo(int n) => n < 2 ? n : Fibo(n - 1) + Fibo(n - 2);
int SumaParesFibo(int n) =>
    Enumerable.Range(1, n).Select(Fibo).Where(x => x % 2 is 0).Sum();
Console.WriteLine(SumaParesFibo(10));