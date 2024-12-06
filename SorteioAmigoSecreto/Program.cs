using System.Reflection.Emit;
using System.Security.Cryptography.X509Certificates;
using Sorteio_AmigoSecreto.Models;


Console.Clear();
List <Pessoa> Participantes = new List<Pessoa>();


char Opc = 'S';


Console.WriteLine("Bem vindo ao sorteio de amigo secreto!");

do
{
    Console.Write("Incluir participante (S/N)? ");
    Opc = char.Parse(Console.ReadLine());
    Opc = char.ToUpper(Opc);

        if (Opc == 'S')
            {   Pessoa Participante = new Pessoa();
                Console.Write("Digite o nome do participante: ");
                string NomeNovoParticipante = Console.ReadLine();

                NomeNovoParticipante = NomeNovoParticipante.ToUpper();
                Participante.Nome = NomeNovoParticipante;
                Participantes.Add(Participante);
                Console.WriteLine("");
            }

        else if (Opc != 'S' && Opc != 'N'){
            Console.WriteLine("Essa opção não existe!");
            Opc = 'S';
        }


        else if (Opc != 'S' && Participantes.Count<2){
            Console.WriteLine("A quantidade de participantes não pode ser menor do que dois!");
            Opc = 'S';
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


while (true){
    Console.Write("Digite o seu nome e veja quem é seu amigo secreto: ");
    string NomeParticipante = Console.ReadLine();
    NomeParticipante = NomeParticipante.ToUpper();

    foreach (Pessoa i in Participantes){
        if (i.Nome == NomeParticipante){
            Console.WriteLine($"O seu amigo secreto é {i.Amigo.Nome}.");

        }
    }
    Console.WriteLine("");
    Console.ReadLine();
    Console.Clear();


}