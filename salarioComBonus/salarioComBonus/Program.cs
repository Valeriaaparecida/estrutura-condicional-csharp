using System;
using System.Globalization;

namespace salarioBonus
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string nome;
            double salario, vendaTotal, valorTotal;

            nome = Console.ReadLine();
            salario = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            vendaTotal = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            valorTotal = salario + 0.15 * vendaTotal;

            Console.WriteLine("TOTAL = R$ " + valorTotal.ToString("F2", CultureInfo.InvariantCulture));
         
        }
    }
}