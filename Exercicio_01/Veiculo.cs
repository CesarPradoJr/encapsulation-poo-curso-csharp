using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace encapsulation_poo_curso_csharp.Exercicio_01;
internal class Veiculo
{
    public string Placa {  get; set; }
    private double velocidadeAtual;

    public Veiculo(string placa) 
    {
        Placa = placa;
    }
    public void AtualizarVelocidade(double novaVelocidade)
    {
        velocidadeAtual = novaVelocidade;
    }
    public double VelocidadeAtual
    {
        get { return velocidadeAtual; }
    }
}
