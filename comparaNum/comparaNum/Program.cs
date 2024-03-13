using System;

namespace MyApp // Note: actual namespace depends on the project name.
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int a, b, c;

            string[] vet = Console.ReadLine().Split(' ');


            a = int.Parse(vet[0]);
            b = int.Parse(vet[1]);
            c = int.Parse(vet[2]);

            if (a < b && a < c)
            {
                Console.WriteLine("MENOR = " + a.ToString());
            }
            else if (b < a && b < c)
            {
                Console.WriteLine("MENOR = " + b.ToString());
            }
            else 
            {
                Console.WriteLine("MENOR = " + c.ToString());
            }
        }
    }
}
