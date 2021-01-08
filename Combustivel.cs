using System;

namespace Lista_02
{
    class Combustivel
    {
        private readonly double etanol = 3.87;
        private readonly double gasolina = 4.65;

        public void Menu()
        {
            int opcao;
            do
            {
                Console.WriteLine("Opções:");
                Console.WriteLine("1 - E-etanol");
                Console.WriteLine("2 - G-gasolina");
                Console.WriteLine("0 - Sair");
                Console.Write("opção: ");
                opcao = int.Parse(Console.ReadLine());
                double litros = 0;
                if (opcao != 0)
                {
                    Console.Write("Quantos litros: ");
                    litros = double.Parse(Console.ReadLine());
                }
                switch (opcao)
                {
                    case 1:
                        CalculoEtanol(litros);
                        break;
                    case 2:
                        CalculoGasolina(litros);
                        break;
                    case 0:
                        break;
                    default:
                        break;
                }
            } while (opcao != 0);
        }

        private void CalculoEtanol(double litros)
        {
            if(litros > 0 && litros <= 20)
                Console.WriteLine($"Total a pagar: R$ {(litros * (etanol - ((etanol / 100) * 3))):F2}\n");
            else if (litros > 20)
                Console.WriteLine($"Total a pagar: R$ {(litros * (etanol - ((etanol / 100) * 5))):F2}\n");
        }

        private void CalculoGasolina(double litros)
        {
            if (litros > 0 && litros <= 20)
                Console.WriteLine($"Total a pagar: R$ {(litros * (gasolina - ((gasolina / 100) * 4))):F2}\n");
            else if (litros > 20)
                Console.WriteLine($"Total a pagar: R$ {(litros * (gasolina - ((gasolina / 100) * 6))):F2}\n");
        }

    }
}
