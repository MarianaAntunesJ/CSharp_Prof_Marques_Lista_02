using System;
using System.Collections.Generic;
using System.Linq;

namespace Lista_02
{
    class Perguntas
    {
        static public void Pergunta01()
        {
            Console.WriteLine("Digite 3 números: ");
            List<int> lista = new List<int>();
            for (int i = 0; i < 3; i++)
                lista.Add(int.Parse(Console.ReadLine()));
            Console.WriteLine("Lista decrescente: ");
            lista.OrderByDescending(_ => _).ToList().ForEach(Console.WriteLine);
        }

        static public void Pergunta02()
        {
            Calculadora calculadora = new Calculadora();
            calculadora.Menu();
        }

        static public void Pergunta03()
        {
            Console.WriteLine("\nObs: Para o cálculo IRRF em 2020, " +
                "é necessário descontar o valor do INSS, quantidade de " +
                "dependentes e de pensões alimentícias, daí usar então como " +
                "base o salário bruto do funcionário\n");
            Console.Write("Digite o valor do salário: ");
            double salario = double.Parse(Console.ReadLine());
            ImpostoRenda impostoRenda = new ImpostoRenda();
            impostoRenda.Calculo(salario);
        }

        static public void Pergunta04()
        {
            Console.Write("Digite o valor de a: ");
            double a = double.Parse(Console.ReadLine());
            Console.Write("Digite o valor de b: ");
            double b = double.Parse(Console.ReadLine());
            Console.Write("Digite o valor de c: ");
            double c = double.Parse(Console.ReadLine());

            double delta = (Math.Pow(b, 2)) - 4 * a * c;

            if (delta >= 0)
            {
                double x1 = (-b + (Math.Sqrt(delta))) / (2 * a);
                double x2 = (-b - (Math.Sqrt(delta))) / (2 * a);
                if (x1 == x2)
                    Console.WriteLine($"Possui uma raíz = {x1}");
                else
                    Console.WriteLine($"x1 = {x1}\nx2 = {x2}");
            }
            else
                Console.WriteLine("Não há raízes reais.");
        }

        static public void Pergunta05()
        {
            Combustivel combustivel = new Combustivel();
            combustivel.Menu();
        }

        static public void Pergunta06()
        {
            Console.Write("Digite o valor de x: ");
            double x = int.Parse(Console.ReadLine());

            if (x <= 1)
                Console.WriteLine($"f(x) = 1");
            else if (x > 1 && x <= 2)
                Console.WriteLine($"f(x) = 2");
            else if (x > 2 && x <= 3)
                Console.WriteLine($"f(x) = {Math.Pow(x, 2)}");
            else if (x > 3)
                Console.WriteLine($"f(x) = {Math.Pow(x, 3)}");
        }

        static public void Pergunta07()
        {
            double total = 0;
            for (int i = 1; i <= 50; i++)
            {
                total += (double)((i * 2) - 1) / i;
            }
            Console.WriteLine($"Total = {total:F2}");
        }

        static public void Pergunta08()
        {
            List<double> soma = new List<double>();
            int resposta = 0;
            Console.WriteLine("Digite os valores: ");
            do
            {
                resposta = int.Parse(Console.ReadLine());
                soma.Add(resposta);
            } while (resposta != 0);
            Console.WriteLine($"Total = {soma.Sum(_ => _)}");
        }

        static public void Pergunta09()
        {
            for (int i = 1000; i <= 1999; i++)
            {
                if (i % 13 == 5)
                    Console.WriteLine(i);
            }
        }

        static public void Pergunta10()
        {
            Console.Write("Digite a quantidade de valores que deseja imprimir: ");
            int quantidade = int.Parse(Console.ReadLine());
            int anterior = 0;
            int atual = 1;
            int proximo = 1;
            for (int i = 0; i <= quantidade; i++)
            {
                Console.WriteLine(proximo);
                proximo = anterior + atual;
                anterior = atual;
                atual = proximo; ;
            }
        }

        static public void Pergunta11()
        {
            List<int> numeros = new List<int>();
            Console.WriteLine("Digite 12 valores: ");
            for (int i = 0; i < 12; i++)
                numeros.Add(int.Parse(Console.ReadLine()));
            int somaPar = 0;
            int somaImpar = 0;
            foreach (int item in numeros)
            {
                if (item % 2 == 0)
                    somaPar += item;
                else
                    somaImpar += item;
            }
            Console.WriteLine($"\nSoma dos pares = {somaPar}\n" +
                                $"Soma dos ímpares = {somaImpar}\n");
        }
    }
}
