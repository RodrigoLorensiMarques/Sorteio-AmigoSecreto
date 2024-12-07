using System.Reflection.Emit;
using System.Security.Cryptography.X509Certificates;
using Sorteio_AmigoSecreto.Models;


Console.Clear();
List <Pessoa> Participantes = new List<Pessoa>();
Pessoa Participante = new Pessoa();

char Opc = 'S';


Console.WriteLine("Bem vindo ao sorteio de amigo secreto!");

do
{
    Console.Write("Incluir participante (S/N)? ");
    Opc = char.Parse(Console.ReadLine());
    Opc = char.ToUpper(Opc);

        if (Opc == 'S'){   
            Pessoa NovoParticipante = new Pessoa();
            Console.Write("Digite o nome do participante: ");
            string NomeNovoParticipante = Console.ReadLine();
                
            NovoParticipante.Nome = NomeNovoParticipante;
            Participantes.Add(NovoParticipante);
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

} 
while (Opc == 'S');

Console.WriteLine("\n");
Console.WriteLine("Fazendo o sorteio... \n");

Participante.Sortear(Participantes);




while (true){
    Console.Write("Digite o seu nome e veja quem é seu amigo secreto: ");
    string NomeParticipante = Console.ReadLine();

    Participante.MostrarAmigo(Participantes, NomeParticipante);
}