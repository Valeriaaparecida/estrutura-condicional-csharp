using System;

namespace MyApp // Note: actual namespace depends on the project name.
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int a , b ;
            string[] iau = Console.ReadLine().Split(' '); 

            a = int.Parse(iau[0]);
            b = int.Parse(iau[1]);

            if ( b % a  == 0 || a % b == 0 )
            {
                Console.WriteLine("Sao Multiplos");
            }else
            {
                Console.WriteLine("Nao sao Multiplos");
            }
        }
    }
}