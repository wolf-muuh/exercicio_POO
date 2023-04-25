using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace exercicio_POO
{
    public class Celular
    {
        public string Cor;
        public string Modelo;
        public string Tamanho;
        public bool Ligado;

        public void Ligar()
        {
            Console.WriteLine($"Deseja ligar o seu celular?");

        }
        public void Desligar()
        {
            Console.WriteLine($"Deseja desligar o seu celular?");
        }
        public void FazerLigação()
        {
            Console.WriteLine($"Deseja fazer uma ligação? digite s para sim n para não");
            string opcao1 = Console.ReadLine().ToLower();
            switch (opcao1)
            {
                case "s":
                    Console.WriteLine($"Digite o número de telefone");
                    string num = Console.ReadLine();
                    break;
                case "n":
                    Console.WriteLine($"Saindo do modo ligação...");
                    break;
                default:
                    Console.WriteLine($"Opção inválida!");
                    break;
            }
        }
        public void EnviarMensagem()
        {
            Console.WriteLine($"Deseja enviar uma mensagem?");
            

        }
    }
}