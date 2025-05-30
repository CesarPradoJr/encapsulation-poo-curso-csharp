using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace encapsulation_poo_curso_csharp;
internal class Funcionario
{
    public string Nome {  get; set; }
    private double salario;

    public Funcionario(string nome, double salarioInicial)
    {
        Nome = nome;
        salario = salarioInicial;
    }

    public void ReajustarSalario(double novoValor)
    {
        if (Salario < novoValor)
        {
            salario = novoValor;
        }
        else
        {
            Console.WriteLine("Erro: O novo salário deve ser maior que o atual.");
        }
    }

    public double Salario
    {
        get
        {
            return salario;
        }
    }
}
