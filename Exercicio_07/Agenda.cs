using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace encapsulation_poo_curso_csharp.Exercicio_07
{
    class Agenda
    {
        public string Proprietario { get; set; }
        private readonly List<Contato> contatos;

        public Agenda(string proprietario)
        {
            Proprietario = proprietario;
            contatos = new List<Contato>();

        }
        public bool AdicionarContato(Contato contato)
        {
            if (contatos.Any(c => c.Nome == contato.Nome))
            {
                Console.WriteLine("Contato já existe na agenda.");
                return false;
            }
            contatos.Add(contato);
            return true;
        }

        public void ListarContatos()
        {
            if (contatos.Count == 0)
            {
                Console.WriteLine("Nenhum contato cadastrado.");
                return;
            }
            Console.WriteLine($"Contatos da agenda de {Proprietario}:");
            foreach (var contato in contatos)
            {
                Console.WriteLine($"Nome: {contato.Nome}, Telefone: {contato.Telefone}");
            }
        }

        public int QuantidadeContatos
        {
            get { return contatos.Count;}
        }
    }
}
