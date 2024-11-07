using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SintaxeC_.Mains
{
    public class Array
    {
        public static void Main(){
            
            int tamanhoArray = 0;
            while (true)
            {
                Console.WriteLine("Informe o tamanho do array de nomes:");
                
                if(int.TryParse(Console.ReadLine(), out tamanhoArray) && tamanhoArray > 0)
                    break;
                
                Console.WriteLine("Valor inválido, tente novamente!");
            }
            
             string[] arrayNomes = new string[tamanhoArray];

             for (int i = 0; i < arrayNomes.Length; i++)
             {
                 Console.WriteLine($"Informe o nome para a posição {i + 1}: ");
                 arrayNomes[i] = Console.ReadLine();
             }

            Console.WriteLine("------------------------------------------------------------------");

            for (int i = 0; i < arrayNomes.Length; i++)
            {
                Console.WriteLine($"Posição: {i + 1} - Elemento: {arrayNomes[i]}");
            }
        }
    }
}