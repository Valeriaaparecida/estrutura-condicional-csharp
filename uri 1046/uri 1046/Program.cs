using System;

namespace MyApp // Note: actual namespace depends on the project name.
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int horaInicial, horaFinal, duracao;

            string[] vet = Console.ReadLine().Split(' ');

            horaInicial = int.Parse(vet[0]);
            horaFinal = int.Parse(vet[1]);

            if (horaFinal > horaInicial) {
                duracao = horaFinal - horaInicial;
            }
            else
            {
                duracao = 24 - horaInicial + horaFinal;
            }

            Console.WriteLine("O JOGO DUROU " +  duracao + " HORA(S)");
        }
    }
}