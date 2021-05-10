using System;

namespace tres
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("CAIXA DO SUPER MERCADO");
            Console.WriteLine("Digite o nome do produto adquirido:");
            string produto = Console.ReadLine();

            Console.WriteLine(produto + " foi o produto adquirido, agora insira as quantidades:");
            float quantidade = int.Parse(Console.ReadLine());
            float total = quantidade * 10;

            if (quantidade <= 5){
                Console.WriteLine("Você adquiriu " + quantidade + " " + produto + "s, então seu desconto é de 2%");
                double valorPago = total * 0.98;
                Console.WriteLine("O valor a ser pago é de R$" + valorPago);
            }
            else if (quantidade > 5 && quantidade <= 10){
                Console.WriteLine("Você adquiriu " + quantidade + " " + produto + "s, então seu desconto é de 3%");
                double valorPago = total * 0.97;
                Console.WriteLine("O valor a ser pago é de R$" + valorPago);
            }
            else if (quantidade > 10){
                Console.WriteLine("Você adquiriu " + quantidade + " " + produto + "s, então seu desconto é de 5%");
                double valorPago = total * 0.95;
                Console.WriteLine("O valor a ser pago é de R$" + valorPago);
            }
        }
    }
}
