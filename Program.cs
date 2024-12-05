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




//Fazer um array para os números sorteados
// A cada sorteio o random deve verificar se esse valor já não foi sorteado e se o número da posição não é o mesmo


Random rnd = new Random();
List<int> PosicoesSorteadas = new List<int>();



for (int i=0; i< Participantes.Count; i++)
    {

    bool PosicaoRepetida = true;
    while (PosicaoRepetida == true)
        {
        PosicaoRepetida = false;
        int Posicao = rnd.Next(0,Participantes.Count);
            for (int j=0; j< PosicoesSorteadas.Count; j++)
            {
                if (Posicao == PosicoesSorteadas[j]){
                    PosicaoRepetida = true;
                }
            }

        PosicoesSorteadas.Add(Posicao);
        Participantes[i].Amigo = Participantes[Posicao];
        }


    }


foreach (Pessoa i in Participantes){
    Console.WriteLine($"O amigo secreto de {i.Nome} é {i.Amigo.Nome}.");
}