using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Globalization;

namespace SintaxeC_.Mains
{
    public class Formatacao
    {
        static CultureInfo culture = new CultureInfo("pt-BR");

        public static void Main()
        {
            decimal reais = 1050.5024m;
            double porcentagem = 0.5677;
            DateTime data = DateTime.Now;

            Console.WriteLine($"Valor: {reais:C}");
            Console.WriteLine($"Valor quatro casas decimais: {reais:C4}");
            Console.WriteLine($"Porcentagem: {porcentagem:P}");
            Console.WriteLine($"Data: {data:dd/MM/yyyy HH:mm:ss}");
        }
    }
}
