using System;

namespace quatro
{
    class Program
    {
        static void Main(string[] args)
        {
            int numeroMaior = 0;
            int numeroMenor = 999;

            Console.WriteLine("ESCREVA 10 NÚMEROS DE ATÉ 3 ALGARISMOS E EU TE DIGO O MAIOR E O MENOR!");
            Console.WriteLine("Insira os 10 números");
            for (var i = 1; i <= 10; i++)
            {
                int numeroVez = int.Parse(Console.ReadLine());

                if (numeroVez > numeroMaior)
                {
                    numeroMaior = numeroVez;
                }
                if (numeroVez < numeroMenor)
                {
                    numeroMenor = numeroVez;
                }
            }
            Console.WriteLine("o numero maior é " + numeroMaior + " e o menor foi " + numeroMenor);
        }
    }
}
