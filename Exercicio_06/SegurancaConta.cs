using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace encapsulation_poo_curso_csharp.Exercicio_06
{
    internal class SegurancaConta
    {
        public bool ValidarSaque(double valorSaque)
        {
            return valorSaque <= 1000 && valorSaque > 0;
        }
    }
}
