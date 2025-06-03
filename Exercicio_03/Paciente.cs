using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace encapsulation_poo_curso_csharp.Exercicio_03;
public class Paciente
{
    public string Nome {  get; set; }
    public int Idade { get; set; }

    public Paciente(string nome, int idade)
    {
        Nome = nome;
        Idade = idade;
    }

}
