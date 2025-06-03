using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace encapsulation_poo_curso_csharp.Exercicio_02;
internal class Avaliacao
{
    public string Aluno { get; set; }
    public double Nota { get; private set; }

    public Avaliacao(string aluno) 
    {
        Aluno = aluno;
    }

    public void AtribuirNota(double nota)
    {
        if (nota >= 0 && nota <= 10)
        {
            Nota = nota;
        }
        else
        {
            Console.WriteLine("Valor inválido a nota deve estar entre 0 e 10.");
        }
    }
}
