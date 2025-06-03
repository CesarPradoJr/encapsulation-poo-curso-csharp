using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace encapsulation_poo_curso_csharp.Exercicio_06
{
    class ContaBancaria
    {
        public string Titular { get; set; }
        private double saldo;  

        public ContaBancaria(string titular, double saldoInicial)
        {
            Titular = titular;
            saldo = saldoInicial;
        }

        public void Sacar(double valorSaque)
        {
            SegurancaConta seguranca = new SegurancaConta();
            if (seguranca.ValidarSaque(valorSaque))
            {
                saldo -= valorSaque;
                Console.WriteLine($"Saque de R${valorSaque.ToString("F2")} realizado com sucesso. Saldo atual: R${saldo.ToString("F2")}");
            }
            else
            {
                Console.WriteLine("Saque não autorizado.");
            }
        }
        public double Saldo
        {
            get { return saldo; }
        }
    }
}
