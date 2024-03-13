using System;
using System.Globalization;

namespace MyApp // Note: actual namespace depends on the project name.
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int codigoProd, quantidade;
            double total;

            string[] vet = Console.ReadLine().Split(' ');

            codigoProd = int.Parse(vet[0]);
            quantidade = int.Parse(vet[1]);

           

           if (codigoProd == 1) {

                total = quantidade * 4.00;

            } 
            else if(codigoProd == 2)
            {
                total = quantidade * 4.50;

            } 
            else if (codigoProd == 3)

            {
                total = quantidade * 5.00;
            } 
            else if (codigoProd == 4)

            {
                total = quantidade * 2.00;  
            } 
            else
            {
                total = quantidade * 1.50;
            }

            Console.WriteLine("Total: R$ " + total.ToString("F2", CultureInfo.InvariantCulture));
        }
    }
}
