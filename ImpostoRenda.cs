using System;

namespace Lista_02
{
    class ImpostoRenda
    {
        public void Calculo(double salario)
        {
            if (salario <= 1903.98)
                Console.WriteLine("Você está isento;");
            else if (salario > 1903.98 && salario <= 2826.65)
                Console.WriteLine($"Valor do IRRF: R${((salario / 100) * 7.5) - 142.80:F2}");
            else if (salario > 2826.65 && salario <= 3751.05)
                Console.WriteLine($"Valor do IRRF: R${((salario / 100) * 15.0) - 354.80:F2}");
            else if(salario > 3751.05 && salario <= 4664.68)
                Console.WriteLine($"Valor do IRRF: R${((salario / 100) * 22.5) - 636.13:F2}");
            else if(salario > 4664.68)
                Console.WriteLine($"Valor do IRRF: R${((salario / 100) * 27.5) - 869.36:F2}");
        }
    }
}
