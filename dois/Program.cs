using System;

namespace dois
{
    class Program
    {
        static void Main(string[] args)
        {
            int alcool, gasolina;

            Console.WriteLine("POSTO DE COMBUSTIVEL:");
            Console.WriteLine("Qual combustivel você quer? (A para álcool e G para gasolina)");
            string tipoCombustivel = Console.ReadLine().ToUpper();

            if (tipoCombustivel == "A")
            {
                Console.WriteLine(tipoCombustivel + " é alcool");
                Console.WriteLine("Quantos litros você quer?");
                alcool = int.Parse(Console.ReadLine());

                if (alcool <= 20)
                {
                    Console.WriteLine(alcool + ", seu desconto por litro é de 3%");
                    double calculoAlcool = alcool * 4.90;
                    double descontoAlcool3 = calculoAlcool * 0.03;
                    double valorAlcool = calculoAlcool - descontoAlcool3;
                    Console.WriteLine("Você pagará R$" + valorAlcool);
                }
                else if(alcool > 20)
                {
                    Console.WriteLine(alcool + ", seu desconto por litro é de 5%");
                    double calculoAlcool = alcool * 4.90;
                    double descontoAlcool5 = calculoAlcool * 0.05;
                    double valorAlcool = calculoAlcool - descontoAlcool5;
                    Console.WriteLine("Você pagará R$" + valorAlcool);
                }
            }
            else if (tipoCombustivel == "G")
            {
                Console.WriteLine(tipoCombustivel + " é gasolina");
                Console.WriteLine("Quantos litros você quer?");
                gasolina = int.Parse(Console.ReadLine());

                if (gasolina <= 20)
                {
                    Console.WriteLine(gasolina + ", seu desconto por litro é de 4%");
                    double calculoGasolina = gasolina * 4.90;
                    double descontoGasolina4 = calculoGasolina * 0.04;
                    double valorGasolina = calculoGasolina - descontoGasolina4;
                    Console.WriteLine("Você pagará R$" + valorGasolina);
                }
                else if(gasolina > 20)
                {
                    Console.WriteLine(gasolina + ", seu desconto por litro é de 6%");
                    double calculoGasolina = gasolina * 4.90;
                    double descontoGasolina6 = calculoGasolina * 0.06;
                    double valorGasolina = calculoGasolina - descontoGasolina6;
                    Console.WriteLine("Você pagará R$" + valorGasolina);
                }
            }
            else
            {
                Console.WriteLine("Isso não é um tipo de combustivel válido!");
            }







        }
    }
}
