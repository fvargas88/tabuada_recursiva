using System;

class Program
{
    static void Main(string[] args)
    {
        Console.Write("Digite um número para a tabuada: ");
        int n = int.Parse(Console.ReadLine());
        ImprimirTabuada(n, 1);
    }

    static void ImprimirTabuada(int n, int i)
    {
        if (i <= 10)
        {
            Console.WriteLine($"{n} x {i} = {n * i}");
            ImprimirTabuada(n, i + 1);
        }
    }
}






