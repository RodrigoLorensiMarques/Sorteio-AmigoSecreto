using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Sorteio_AmigoSecreto.Models
{
    public class Pessoa
    {
        public string Nome { get; set; }
        public Pessoa Amigo { get; set; }
    }
}