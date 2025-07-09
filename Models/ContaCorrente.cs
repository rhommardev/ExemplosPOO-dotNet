using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ExemplosPOO.Models
{
    public class ContaCorrente
    {
        //contrutor
        public ContaCorrente(int numeroConta, decimal saldoInicial)
        {
            NumeroConta = numeroConta;
            Saldo = saldoInicial;
        }

        //propriedades
        public int NumeroConta { get; set; }
        private decimal Saldo;

    //metodo
        public void Sacar(decimal valor)
        {
            Saldo -= valor;
        }        
    }
}