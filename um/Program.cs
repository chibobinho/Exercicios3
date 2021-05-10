using System;

namespace um
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("VOCÊ DEVE VOTAR ESSE ANO?");
            Console.WriteLine("Escreva seu ano de nascimento:");
            float anoNascimento = int.Parse(Console.ReadLine());

            float calculo = 2021 - anoNascimento;

            if (calculo >= 16)
            {
                Console.WriteLine("Você não pode, você DEVE votar!");
            }
            else
            {
                Console.WriteLine("Infelizmente você não pode nos ajudar a derrubar a elite :(");
            }
        }
    }
}
