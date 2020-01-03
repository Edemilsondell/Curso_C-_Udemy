using System;
using System.Globalization;
namespace calcPrateleira {
    class Program {
        static void Main(string[] args) {

            Divisao x, n, z;

            x = new Divisao();
            n = new Divisao();
            z = new Divisao();

            double total, soma;

            Console.WriteLine("Digite o espaço a ser dividido: ");
            x.espaco = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            Console.WriteLine("Digite a quantidade de prateleira: ");
            n.quantidade = int.Parse(Console.ReadLine());
            Console.WriteLine("Digite a espessura da prateleira: ");
            z.espessura = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);


            soma = n.quantidade * z.espessura;

            Console.WriteLine("\nSoma da Divisórias = " + soma.ToString("F1", CultureInfo.InvariantCulture));

            total = (x.espaco - soma) / (n.quantidade + 1);

            Console.WriteLine("\nEspaço entre as prateleiras = " + total.ToString("F1", CultureInfo.InvariantCulture));

        }
    }
}
