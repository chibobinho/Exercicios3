using System;

namespace seis
{
    class Program
    {
        static void Main(string[] args)
        {
            bool achou = false;

            string[] AmoresDaSuaVida = null;
            AmoresDaSuaVida = new string [9];
            Console.WriteLine("BEM VINDO AO TINDER, AQUI VOCÊ ENCONTRARÁ AQUELA SUA CRUSHZINHA DO SEXTO ANO");

            int c = 0;
            foreach (var item in AmoresDaSuaVida)
            {
                AmoresDaSuaVida[c] = Console.ReadLine();
                c++;
            }
            
            Console.WriteLine("Agora fala o nome da sua crushzinha do sexto ano:");
            string suaCrush = Console.ReadLine();
            c = 0;
            foreach (var item in AmoresDaSuaVida)
            {
                if (suaCrush == AmoresDaSuaVida[c])
                {
                    achou = true;
                }
            }

            if (achou == true)
            {
                Console.WriteLine("Boa, você achou sua crush do sexto, mas talvez ela namore, afinal, já faz tempo que você saiu do sexto ano.");
            }
            else
            {
                Console.WriteLine("Pena amigão, vai ser solteiro pra sempre!");
            }
        }
    }
}
