using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using SintaxeC_.models;

namespace SintaxeC_.Mains
{
    public class Calculadora
    {
        public static void Main(){
            Console.WriteLine("TESTANDO CLASSE CALCULADORA");

            models.Calculadora.Somar(1, 2);

            models.Calculadora.Subtrair(1, 2);

            models.Calculadora.Multiplicar(1, 2);

            models.Calculadora.Dividir(1, 2);

            models.Calculadora.Potencia(5, 2);

            models.Calculadora.Seno(30);

            models.Calculadora.Cosseno(30);

            models.Calculadora.Tangente(30);

            models.Calculadora.RaizQuadrada(25);
        }
    }
}