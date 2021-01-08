using System;
using System.Collections.Generic;
using System.Linq;

namespace Lista_02
{
    class Calculadora
    {
        public void Menu()
        {
            int opcao;
            do
            {
                Console.WriteLine("Opções:");
                Console.WriteLine("1 - Adição");
                Console.WriteLine("2 - Subtração");
                Console.WriteLine("3 - Multiplicação");
                Console.WriteLine("4 - Divisão");
                Console.WriteLine("5 - Raiz quadrada");
                Console.WriteLine("6 - Elevação ao quadrado");
                Console.WriteLine("7 - Porcetagem");
                Console.WriteLine("0 - Sair\n");
                Console.Write("opção: ");
                opcao = int.Parse(Console.ReadLine());
                switch (opcao)
                {
                    case 1:
                        Adicao();
                        break;
                    case 2:
                        Subtracao();
                        break;
                    case 3:
                        Multiplicacao();
                        break;
                    case 4:
                        Divisao();
                        break;
                    case 5:
                        RaizQuadrada();
                        break;
                    case 6:
                        ElevacaoAoQuadrado();
                        break;
                    case 7:
                        Porcentagem();
                        break;
                    case 0:
                        break;
                    default:
                        Console.WriteLine("Opção inválida. Tente novamente.");
                        break;
                }
            } while (opcao != 0);
        }

        private List<double> CalculoLista(char operacao)
        {
            string[] vetorS = Console.ReadLine().Split($" {operacao} ");
            double[] vetorD = vetorS.Select(double.Parse).ToArray(); 
            return new List<double>(vetorD);
        }

        private void Adicao()
        {
            Console.WriteLine("Formato: numero + numero + ... (enter)");
            Console.WriteLine($"Resultado = {CalculoLista('+').Sum(_ => _)}\n");
        }

        private void Subtracao()
        {
            Console.WriteLine("Formato: numero - numero - ... (enter)");
            List<double> lista = CalculoLista('-');
            double total = lista[0];
            for (int i = 1; i < lista.Count(); i++)
                total -= lista[i];
            Console.WriteLine($"Resultado = {total}\n");
        }

        private void Multiplicacao()
        {
            Console.WriteLine("Formato: numero * numero * ... (enter)");
            List<double> lista = CalculoLista('*');
            double total = lista[0];
            for (int i = 1; i < lista.Count(); i++)
                total *= lista[i];
            Console.WriteLine($"Resultado = {total}\n");
        }

        private void Divisao()
        {
            Console.WriteLine("Formato: numero / numero / ... (enter)");
            List<double> lista = CalculoLista('/');
            double total = lista[0];
            for (int i = 1; i < lista.Count(); i++)
                total /= lista[i];
            Console.WriteLine($"Resultado = {total}\n");
        }

        private double CalculoIndividual()
        {
            Console.Write("Digite um número: ");
            return double.Parse(Console.ReadLine());
        }

        private void RaizQuadrada()
        {
            Console.WriteLine($"Resultado = {Math.Sqrt(CalculoIndividual())}");
        }

        private void ElevacaoAoQuadrado()
        {
            Console.WriteLine($"Resultado = {Math.Pow(CalculoIndividual(), 2)}");
        }

        private void Porcentagem()
        {
            Console.Write("A porcentagem: ");
            double valor = double.Parse(Console.ReadLine());
            Console.Write("de: ");
            double total = double.Parse(Console.ReadLine());
            Console.WriteLine($"Resultado = {(total / 100) * valor}%");
        }
    }
}
