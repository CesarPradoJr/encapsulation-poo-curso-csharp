using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace encapsulation_poo_curso_csharp.Exercicio_10
{
    class Reserva
    {
        private int diarias;
        public Hospede Hospede { get; }
        public Quarto Quarto { get; }
        public Reserva(Hospede hospede, Quarto quarto, int diarias)
        {
            if(diarias <= 0)
            {
                throw new ArgumentException("O número de diárias deve ser maior que zero.");
            }

            Hospede = hospede;
            Quarto = quarto;
            this.diarias = diarias;
        }
        public double ValorTotal
        {
            get { return Quarto.ValorDiaria * diarias; }
        }
    }
}
