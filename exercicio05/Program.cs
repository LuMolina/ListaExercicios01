using System;

namespace Exercicio05
{
    public class Program
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("Digite um valor inteiro de 1 a 7. ");
            int diaSemana = Convert.ToInt32(Console.ReadLine());
            switch (diaSemana)
            {
case 1:
            Console.WriteLine("O dia é domingo. ");
            break;
            case 2:
            Console.WriteLine("O dia é Segunda-feira. ");
            break;
            case 3:
            Console.WriteLine("O dia é Terça-feira. ");
            break;
            case 4:
            Console.WriteLine("O dia é quarta-feira. ");
            break;
            case 5:
            Console.WriteLine("O dia é quinta-feira. ");
            break;
            case 6:
            Console.WriteLine("O dia é sexta-feira. ");
            break;
            case 7:
            Console.WriteLine("O dia é sábado. ");
            break;
            default:
            Console.WriteLine("Número inválido para dia da semana. ");
            break;






 


            }

        }
    }
}