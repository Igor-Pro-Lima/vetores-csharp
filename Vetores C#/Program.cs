using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Globalization;

namespace Vetores_C_ {
    internal class Program {
        static void Main(string[] args) {

            ///CI Usado para alterar o ponto para virgula de uma variável double.
            CultureInfo CI = CultureInfo.InvariantCulture;

            int N;
            Console.Write("Quantos numeros voce vai digitar?");
            N = int.Parse(Console.ReadLine());

            double[] vet = new double[5];

            for (int i = 0; i < N; i++) {
                Console.Write("Digite um numero: ");
                vet[i] = double.Parse(Console.ReadLine(), CI);
            }

            Console.WriteLine();
            Console.WriteLine("NUMEROS DIGITADOS:");
            for (int i = 0; i < N; i++) {
                Console.WriteLine(vet[i].ToString("F1", CI));

            }
        }
    }
}
