// Crie uma Classe de um Celular, com as propriedades cor, modelo, tamanho, ligado(booleano).
// Com os métodos, ligar, desligar, fazer ligação, enviar mensagem.
// Só será possível executar tais métodos se o celular estiver ligado.
// Envie o link do repositório como entrega desta atividade.
using exercicio_POO;
Celular celular = new Celular();

Console.WriteLine($"Bem vindo ao sistema mundial de celular!");
Console.WriteLine(@$"
Digite as seguintes especificações do seu celular:
Cor;
Modelo;
Tamanho.
");
celular.Cor = Console.ReadLine();
celular.Modelo = Console.ReadLine();
celular.Tamanho = Console.ReadLine();

celular.Ligar();


if (celular.Ligado == true)
{
    string OPCAO = "";
    do
    {


        Console.WriteLine(@$"
    Escolhas uma das funcionalidades do seu celular através dos números que a representa:
    1 - Ligar 
    2 - mandar mensagem 
    3 - especificações do aparelho
    0 - sair
    ");
        OPCAO = Console.ReadLine();
        switch (OPCAO)
        {   
            case "1":
                celular.FazerLigação();
                break;

            case "2":
                celular.EnviarMensagem();
                break;
            case "3":
                Console.WriteLine(@$"
            Especificações:
            Cor: {celular.Cor};
            Modelo: {celular.Modelo};
            Tamanho: {celular.Tamanho}.
            ");

                break;
            case "0":
                celular.Desligar();
                break;
            default:
                Console.WriteLine($"Digite uma opção válida.");
                break;
        }
    } while (OPCAO != "0");


}



