using System.Reflection.Emit;
using System.Security.Cryptography.X509Certificates;
using Sorteio_AmigoSecreto.Models;



List <Pessoa> Participantes = new List<Pessoa>();


char Opc = 'S';


Console.WriteLine("Bem vindo ao sorteio de amigo secreto!");

do
{
    Console.Write("Incluir participante (S/N)? ");
    Opc = char.Parse(Console.ReadLine());

        if (Opc == 'S')
            {   Pessoa Participante = new Pessoa();
                Console.Write("Digite o nome do participante: ");
                Participante.Nome = Console.ReadLine();
                Participantes.Add(Participante);
            }


} while (Opc == 'S');

Console.WriteLine("\n");
Console.WriteLine("Fazendo o sorteio... \n");




Random rnd = new Random();
List<int> PosicoesSorteadas = new List<int>();



for (int i=0; i< Participantes.Count; i++)
    {

    bool PosicaoRepetida = true;
    int Posicao = -1;

    while (PosicaoRepetida == true)
        {
        
        PosicaoRepetida = false;
        Posicao = rnd.Next(0,Participantes.Count);

        if (Posicao == i){
            PosicaoRepetida = true;
        }
        
        foreach (int j in PosicoesSorteadas){
            if (Posicao == j){
                PosicaoRepetida = true;
            }
        }

        }

        PosicoesSorteadas.Add(Posicao);
        Participantes[i].Amigo = Participantes[Posicao];


    }


foreach (Pessoa i in Participantes){
    Console.WriteLine($"O amigo secreto de {i.Nome} é {i.Amigo.Nome}.");

}

