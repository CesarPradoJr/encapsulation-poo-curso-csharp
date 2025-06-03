using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace encapsulation_poo_curso_csharp.Exercicio_03;
internal class HistorioMedico
{
    public string CodigoProntuario { get; set; }

    public HistorioMedico(string codigoProntuario) 
    {
        CodigoProntuario = codigoProntuario;
    }
    public void ExibirCodigo()
    {
        Console.WriteLine($"Código do prontuário: {CodigoProntuario}");
    }
}
