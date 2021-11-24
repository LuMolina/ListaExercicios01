using System;

namespace Exercicio06
{
    public class Program
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("Digite um valor inteiro.");
            string? textoValor01 = Console.ReadLine();
            int valor01 = Convert.ToInt32(textoValor01);
if (valor01 == 1)
{
            Console.WriteLine("O dia da semana correspondente ao valor digitado é domingo. ");
}
else if (valor01 == 2)
{
Console.WriteLine("O dia da semana correspondente ao valor digitado é segunda-feira. ");
}
else if (valor01 == 3)
{
Console.WriteLine("O dia da semana correspondente ao valor digitado é terça-feira. ");
}
else if (valor01 ==4)
{
Console.WriteLine("O dia da semana correspondente ao valor digitado é quarta-feira. ");
}
else if (valor01 == 5)
{
Console.WriteLine("O dia da semana correspondente ao valor digitado é quinta-feira. ");
}
else if (valor01 ==6)
{
Console.WriteLine("O dia da semana correspondente ao valor digitado é sexta-feira. ");
}
else if (valor01 == 7)
{
Console.WriteLine("O dia da semana correspondente ao valor digitado é sábado. ");
}
else
{
Console.WriteLine("O dia da semana correspondente ao valor digitado é inválido. ");
}
    }








        }
    }
