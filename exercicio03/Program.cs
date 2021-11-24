using System;

namespace Exercicio03
{
    public class Program
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("Digite o valor do primeiro produto: ");
            string textoProduto01 = Console.ReadLine();
                        Console.WriteLine("Digite o valor do segundo produto: ");
                        string textoProduto02 = Console.ReadLine();
                        Console.WriteLine("Digite o valor do terceiro produto: ");
                        string textoProduto03 = Console.ReadLine();
                        
double produto01 = Convert.ToDouble(textoProduto01);
                        double produto02 = Convert.ToDouble(textoProduto02);
double produto03 = Convert.ToDouble(textoProduto03);
if(produto01 < produto03 && produto01 < produto03)
{
                        Console.WriteLine("Você deve comprar o produto com valor de: " + produto01);
}
else if(produto02 < produto01 && produto02 < produto03)
{
Console.WriteLine("Você deve comprar o produto com valor de: " + produto02);
}
else
{
Console.WriteLine("Você deve comprar o produto com valor de: " + produto03);
}
}
}
}
