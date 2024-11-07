using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Threading.Tasks;

namespace Estacionamento.models
{
    public class Estacionamento
    {
        public decimal ValorInicial { get; set; }

        public decimal ValorPorHora { get; set; }

        public List<string> Veiculos { get; set; }


        public Estacionamento(decimal valorInicial, decimal valorPorHora)
        {
            this.ValorInicial = valorInicial;
            this.ValorPorHora = valorPorHora;
            this.Veiculos = new List<string>();
        }

        public void CadastrarVeiculo()
        {
            while (true)
            {
                Console.WriteLine("Informe a placa do veículo ([ 0 ] para voltar): ");
                
                var placa = Console.ReadLine().Trim().ToUpper();
                if (placa == "0")
                    return;

                if (this.Veiculos.Contains(placa))
                {
                    Console.WriteLine("Veículo já cadastrado! Informe outro veículo.");
                    continue;
                }

                this.Veiculos.Add(placa);
                Console.WriteLine("Veículo cadastrado com sucesso!");
                break;
            }
        }


        public void RemoverVeiculo()
        {

            while (true)
            {
                Console.WriteLine("Informe a placa do veículo que deseja remover ([ 0 ] para voltar): ");
            
                var placa = Console.ReadLine().Trim().ToUpper();
                if (placa == "0")
                    return;

                if (!this.Veiculos.Contains(placa))
                {
                    Console.WriteLine("Veículo não encontrado!");
                    continue;
                }
                
                while (true)
                {
                    Console.WriteLine("Digite a quantidade de horas que o veículo ficou estacionado: ");

                    if(!int.TryParse(Console.ReadLine().Trim(), out int horas))
                    {
                        Console.WriteLine("Valor inválido, tente novamente!");
                        continue;
                    }

                    Console.WriteLine($"O Veículo {placa} foi removido e o valor total a ser pago foi de: R$ {this.ValorInicial + (this.ValorPorHora * horas)}");
                    this.Veiculos.Remove(placa);
                    
                    return;
                }
                
            }
            
        }

        public void ListaVeiculos()
        {
            if (this.Veiculos.Count == 0)
            {
                Console.WriteLine("Nenhum veículo cadastrado!");
                return;
            }

            Console.WriteLine("Veículos cadastrados: ");
            foreach (var veiculo in this.Veiculos)
            {
                Console.WriteLine(veiculo);
            }
        }

    }
}