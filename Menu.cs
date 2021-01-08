using System;

namespace Lista_02
{
    class Menu
    {
        static public void MenuOpcoes()
        {
            int resp;
            do
            {
                Console.WriteLine("\nMenu: ");
                Console.WriteLine(" 1 - Ordem decrescente;");
                Console.WriteLine(" 2 - Calculadora;");
                Console.WriteLine(" 3 - Imposto de renda;");
                Console.WriteLine(" 4 - Bhaskara;");
                Console.WriteLine(" 5 - Combustível;");
                Console.WriteLine(" 6 - f(x);");
                Console.WriteLine(" 7 - Soma dos impares;");
                Console.WriteLine(" 8 - Soma enquanto entrada diferente de zero;");
                Console.WriteLine(" 9 - Resto 5;");
                Console.WriteLine("10 - Fibonacci;");
                Console.WriteLine("11 - Soma de ímpares e pares;");
                Console.WriteLine(" 0 - Sair;\n");
                Console.Write("opção: ");
                resp = int.Parse(Console.ReadLine());
                switch (resp)
                {
                    case 1:
                        Perguntas.Pergunta01();
                        break;
                    case 2:
                        Perguntas.Pergunta02();
                        break;
                    case 3:
                        Perguntas.Pergunta03();
                        break;
                    case 4:
                        Perguntas.Pergunta04();
                        break;
                    case 5:
                        Perguntas.Pergunta05();
                        break;
                    case 6:
                        Perguntas.Pergunta06();
                        break;
                    case 7:
                        Perguntas.Pergunta07();
                        break;
                    case 8:
                        Perguntas.Pergunta08();
                        break;
                    case 9:
                        Perguntas.Pergunta09();
                        break;
                    case 10:
                        Perguntas.Pergunta10();
                        break;
                    case 11:
                        Perguntas.Pergunta11();
                        break;
                    case 0:
                        break;
                    default:
                        Console.WriteLine("Opção inválida. Tente novamente.");
                        break;
                }
            } while (resp != 0);
        }
    }
}
