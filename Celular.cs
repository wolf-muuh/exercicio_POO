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
            string opcao = "";
            do
            {


                Console.WriteLine($"Deseja ligar o seu celular? digite s para sim e n para não");
                opcao = Console.ReadLine().ToLower();
                switch (opcao)
                {
                    case "s":
                        Console.WriteLine($"Celular ligado!");
                        Ligado = true;
                        break;
                    case "n":
                        Console.WriteLine($"programa encerrado");
                        Ligado = false;

                        break;

                    default:
                        Console.WriteLine($"Digite uma opção válida");

                        break;
                }
            } while (opcao != "s" && opcao != "n");


        }
        public void Desligar()
        {
            string opcao0 = "";
            do
            {


                Console.WriteLine($"Deseja desligar o seu celular?Digite s para sim e n para não");
                opcao0 = Console.ReadLine().ToLower();
                if (opcao0 == "s")
                {
                    Console.WriteLine($"Fim do programa. Tenha um bom dia!");

                }


            } while (opcao0 != "s");
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
                    Console.WriteLine($"Fazendo uma ligação para {num}");
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
            string opcao2 = "";
            do
            {


                Console.WriteLine($"Deseja enviar uma mensagem? digite s para sim e n para não");
                opcao2 = Console.ReadLine().ToLower();
                switch (opcao2)
                {
                    case "s":
                        string nomMsg = "";
                        do
                        {
                            Console.WriteLine($"Digite o nome do contato que você deseja enviar uma mensagem: ");
                            nomMsg = Console.ReadLine();
                            if (nomMsg == "")
                            {
                                Console.WriteLine($"ERRO! Espaço em branco!");

                            }
                        } while (nomMsg == "");
                        string msg = "";

                        do
                        {


                            Console.WriteLine($"Digite sua mensagem para {nomMsg}: ");
                            msg = Console.ReadLine();
                            if (msg == "")
                            {
                                Console.WriteLine($"ERRO! Espaço em branco!");

                            }

                            else
                            {
                                string opcao3 = "";
                                do
                                {


                                    Console.WriteLine($"Sua mensagem é: {msg} deseja envia-la? digite s para sim n para não");
                                    opcao3 = Console.ReadLine().ToLower();
                                    switch (opcao3)
                                    {
                                        case "s":
                                            Console.WriteLine($"Mensagem para {nomMsg} enviada com sucesso, a mensagem foi: {msg}");

                                            break;
                                        case "n":
                                            Console.WriteLine($"Mensagem para {nomMsg} não enviada!");
                                            break;

                                        default:
                                            Console.WriteLine($"Selecione uma das opções válidas");

                                            break;
                                    }
                                } while (opcao3 == "");

                            }
                        } while (msg == "");

                        break;
                    default:
                        Console.WriteLine($"Selecione uma das opções válidas");

                        break;
                }
            } while (opcao2 == "");

        }
    }
}