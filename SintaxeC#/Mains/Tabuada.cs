using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SintaxeC_.Mains
{
    public class Tabuada
    {       
        public static void Main()
        {
            int num = 0;
            while (true)
            {
                Console.WriteLine("Digite um número para ver a tabuada: ");
                if(int.TryParse(Console.ReadLine(), out num) && num > 0)
                    break;
                else
                    Console.WriteLine("Digite um número válido e maior que zero!");

            }

            for (int i = 1; i <= 10; i++)
            {
                Console.WriteLine(num + " x " + i + " = " + (num * i));
            }
        }
    }
}