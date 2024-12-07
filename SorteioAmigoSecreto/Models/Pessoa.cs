using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Threading.Tasks;

namespace Sorteio_AmigoSecreto.Models
{
    public class Pessoa
    {
        private string nome;
        public string Nome 
        {
            get {
                return nome;
        }
        
            set {
                nome = value.ToUpper();
        }
         }
        public Pessoa Amigo { get; set; }


        public void Sortear(List<Pessoa> Participantes ){
            Random rnd = new Random();
            List<int> PosicoesSorteadas = new List<int>();


            for (int i=0; i< Participantes.Count; i++){

                bool PosicaoRepetida = true;
                int Posicao = -1;

                while (PosicaoRepetida == true){
                    
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
        }

        public void MostrarAmigo (List<Pessoa> Participantes, string NomeParticipante){

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

    }
}