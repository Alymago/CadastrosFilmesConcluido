using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Filmes.Models
{
    public class Filmes
    {
        public Filmes()
        {
            FilmeId = Guid.NewGuid();
        }
        public Guid FilmeId { get; set; }
        public int Quantidade { get; set; }
        public string Nome { get; set; }
        public string Diretor { get; set; }
        public string Genero { get; set; }
        public bool Censurado { get; set; }
    }
}