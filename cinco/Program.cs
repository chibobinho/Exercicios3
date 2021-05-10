using System;

namespace cinco
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("TABUADAS DO 1 ATÉ O 10 VOCÊ SÓ ENCONTRA AQUI, CONFIA!");

            for (int i = 0; i <= 10; i++)
            {
                Console.WriteLine("Tabuada do " + i);
                for (var a = 1; a <= 10; a++)
                {
                Console.WriteLine(i + " * " + a + " = " + (i*a));
                }
            }



        }
    }
}
