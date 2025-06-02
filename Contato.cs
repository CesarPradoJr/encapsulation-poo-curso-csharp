using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace encapsulation_poo_curso_csharp
{
    class Contato
    {
        public string Nome { get; set; }
        public string Telefone { get; set; }
        public Contato(string nome, string telefone)
        {
            Nome = nome;
            Telefone = telefone;
        }
    }
}
