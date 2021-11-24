using System;

namespace Exercicio02
{
    public class Program
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("Digite o primeiro valor: ");
            string? textoValor01 = Console.ReadLine();
            Console.WriteLine("Digite o segundo valor: ");
            string? textoValor02 = Console.ReadLine();
            Console.WriteLine("Digite o terceiro valor: ");
            string? textoValor03 = Console.ReadLine();

            int valor01 = Convert.ToInt32(textoValor01);
            int valor02 = Convert.ToInt32(textoValor02);
            int valor03 = Convert.ToInt32(textoValor03);
            int maior = 0;
            if (valor01 > valor02)
            {
                if (valor01 > valor03)
                {
                    maior = valor01;
                }
                else
                {
                    maior = valor03;
                }


            }
            else
            {
                if (valor02 > valor03)
                {
                    maior = valor02;
                }
                else
                {
                    maior = valor03;
                }
            }
            int menor = 0;
if (valor01 < valor02)
            {
                if (valor01 < valor03)
                {
                    menor = valor01;
                }
                else
                {
                    menor = valor03;
                }


            }
            else
            {
                if (valor02 < valor03)
                {
                    menor = valor02;
                }
                else
                {
                    menor = valor03;
                }
            }
            Console.WriteLine("O maior número é: " + maior + "O menor número é: " + menor);








        }
    }
}