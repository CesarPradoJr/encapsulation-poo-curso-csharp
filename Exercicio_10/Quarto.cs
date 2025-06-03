using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace encapsulation_poo_curso_csharp.Exercicio_10
{
    class Quarto
    {
        public int Numero { get; set; }
        private double valorDiaria;
        public double ValorDiaria
        {
            get { return valorDiaria; }
            set
            {
                if (value < 0)
                {
                    throw new ArgumentException("O valor da diária não pode ser negativo.");
                }
                valorDiaria = value;
            }
        }
        public Quarto(int numero)
        {
            Numero = numero;
        }
    }
}
