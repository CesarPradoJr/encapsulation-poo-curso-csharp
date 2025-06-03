using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace encapsulation_poo_curso_csharp.Exercicio_05;
internal class Projeto
{
    public string Nome { get; set; }
    private List<string> tarefas;

    public Projeto(string nome)
    {
        Nome = nome;
        tarefas = new List<string>();
    }

    public void AdicionarTarefa(string tarefa)
    {
        tarefas.Add(tarefa);
    }

    public void ExibirTarefas()
    {
        Console.WriteLine($"Projetos: {Nome}");
        Console.WriteLine($"Tarefas:");
        foreach (string tarefa in tarefas) 
        {
            Console.WriteLine($"- {tarefa}");
        }
        Console.WriteLine($"Total: {QuantidadeTarefas} tarefas");
    }

    public int QuantidadeTarefas
    {
        get { return tarefas.Count; }
    }

}
