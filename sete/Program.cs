using System;

namespace sete
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] sequencia = null;
            sequencia = new int [15];
            Console.WriteLine("Ae mano, declara 15 numeros, quer ver eu colocar eles na ordem inversa? Truque de mágica, imperdivel!");

            int c = 0;
            foreach (var item in sequencia)
            {
                sequencia[c] = int.Parse(Console.ReadLine());
                c++;
            }

            Console.WriteLine("ALAKAZAN!");

            c = 14;
            foreach (var item in sequencia)
            {
                Console.WriteLine(sequencia[c]);
                c--;
            }



        }
    }
}
