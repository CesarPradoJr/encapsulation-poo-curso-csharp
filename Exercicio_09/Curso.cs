using encapsulation_poo_curso_csharp.Exercicio_08;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace encapsulation_poo_curso_csharp.Exercicio_09
{
    class Curso
    {
        public string Nome { get; set; }
        public int VagasTotais { get; set; }

        private List<string> matriculas;

        public Curso(string nome, int vagasTotais)
        {
            Nome = nome;
            VagasTotais = vagasTotais;
            matriculas = new List<string>();
        }
        public bool Matricular(Estudante_Exercicio_09 estudante)
        {
            if (matriculas.Count - VagasDisponiveis  >= VagasTotais)
            {
                Console.WriteLine($"Não foi possível matricular {estudante.Nome} vagas indisponíveis para o curso {Nome}.");
                return false;
            }
            matriculas.Add(estudante.Nome);
            Console.WriteLine($"Estudante {estudante.Nome} matriculado com sucesso no curso {Nome}.");
            return true;
        }
        public void ListarMatriculados()
        {
            if (matriculas.Count == 0)
            {
                Console.WriteLine("Nenhum estudante matriculado.");
                return;
            }
            Console.WriteLine("Estudantes matriculados:");
            foreach (var matricula in matriculas)
            {
                Console.WriteLine(matricula);
            }
        }
        public int VagasDisponiveis
        {
            get{ return VagasTotais - matriculas.Count; }
        }
    }
}
