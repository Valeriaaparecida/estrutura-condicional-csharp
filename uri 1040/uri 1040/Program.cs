using System;
using System.Net.Http.Headers;

namespace MyApp // Note: actual namespace depends on the project name.
{
    internal class Program
    {
        static void Main(string[] args)
        {
            float a, b, c, d, media;

            string[] vet = (Console.ReadLine().Split(' '));

            a = float.Parse(vet[0]);
            b = float.Parse(vet[1]);
            c = float.Parse(vet[2]);
            d = float.Parse(vet[3]);

            media = (a * 2f + b * 3f + c * 4f + d) / (1f + 2f + 3f + 4f);

            if (media >= 7f)
            {
                Console.WriteLine("Media: " + media);
                Console.WriteLine("Aluno aprovado");
            }
            else if (media >= 5f && media <= 6.9)
            {
                Console.WriteLine("Media: " + media);
                Console.WriteLine("Aluno em exame.");
            } else
            {
                Console.WriteLine("Media: " + media);
                Console.WriteLine("Aluno reprovado");
            }

        }
    }
}
