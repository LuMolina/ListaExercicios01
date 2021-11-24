using System;

namespace Exercicio04
{
    public class Program
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("Digite o valor do seu salário: ");
            string textoSalario = Console.ReadLine();
            double salario = Convert.ToDouble(textoSalario);
            Console.WriteLine("O valor do seu salário antes do reajuste é de> " + salario);
            if (salario <= 2800)
            {
                Console.WriteLine("O seu aumento é de 20%. ");

            }
            else if (salario > 2800 && salario <= 7000)
            {
                Console.WriteLine("O seu aumento é de 15%. ");

            }
            else if (salario <= 15000 && salario > 7000)
            {
                Console.WriteLine("O seu aumento é de 10%. ");

            }
            else if (salario > 15000)
            {
                Console.WriteLine("O seu aumento é de 5%. ");

            }
            else
            {
                Console.WriteLine("Salário inelegível para aumento. ");

            }
            double salario1 = salario * 0.20;
            double salario2 = salario * 0.15;
            double salario3 = salario * 0.10;
            double salario4 = salario * 0.05;
            if (salario <= 2800)
            {
                Console.WriteLine("O seu aumento foi: " + salario1);

            }
            else if (salario > 2800 && salario <= 7000)
            {
                Console.WriteLine("O seu aumento foi de: " + salario2);

            }
            else if (salario <= 15000 && salario > 7000)
            {
                Console.WriteLine("O seu aumento foi de: " + salario3);

            }
            else if (salario > 1500)
            {
                Console.WriteLine("O seu aumento foi de: " + salario4);

            }
            else
            {
                Console.WriteLine("Salário inelegível para aumento. ");

            }
            double total1 = salario + salario1;
            double total2 = salario + salario2;
            double total3 = salario + salario3;
            double total4 = salario + salario4;
            if (salario <= 2800)
            {
                Console.WriteLine("O seu salário final é de: " + total1);

            }
            else if (salario > 2800 && salario <= 7000)
            {
                Console.WriteLine("O seu salário total é de: " + total2);

            }
            else if (salario <= 15000 && salario > 7000)
            {
                Console.WriteLine("O seu salário total é de: " + salario3);

            }
            else if (salario > 1500)
            {
                Console.WriteLine("O seu salário total é de: " + total4);

            }
            else
            {
                Console.WriteLine("Salário inelegível para aumento. ");

            }

        }
    }
}