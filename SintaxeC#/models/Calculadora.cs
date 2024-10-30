using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SintaxeC_.models
{
    public static class Calculadora
    {
        public static void Somar(int x, int y){
            Console.WriteLine($"{x} + {y} = {x + y}");
        }

        public static void Subtrair(int x, int y){
            Console.WriteLine($"{x} - {y} = {x - y}");
        }

        public static void Multiplicar(int x, int y){
            Console.WriteLine($"{x} X {y} = {x * y}");
        }

        public static void Dividir(double x, double y){
            Console.WriteLine($"{x} / {y} = {x / y}");
        }   

        public static void Potencia(int x, int y){
            Console.WriteLine($"{x}^{y} = {Math.Pow(x, y)}");
        }

        public static void Seno(double angulo){
            double radiano = angulo * Math.PI / 180;
            var sen = Math.Sin(radiano);
            Console.WriteLine($"sen({angulo}) = {Math.Round(sen, 4)}");
        }

        public static void Cosseno(double angulo){
            double radiano = angulo * Math.PI / 180;
            var cos = Math.Cos(radiano);
            Console.WriteLine($"cos({angulo}) = {Math.Round(cos, 4)}");
        }

        public static void Tangente(double angulo){
            double radiano = angulo * Math.PI / 180;
            var tan = Math.Tan(radiano);
            Console.WriteLine($"tan({angulo}) = {Math.Round(tan, 4)}");
        }

        public static void RaizQuadrada(double x){
            var raiz = Math.Sqrt(x);
            Console.WriteLine($"√{x} = {Math.Round(raiz, 4)}");
        }
    }
}