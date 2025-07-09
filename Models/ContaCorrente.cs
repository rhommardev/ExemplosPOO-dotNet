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
        { //criando condição 
            if (Saldo >= valor)
            {
                Saldo -= valor;
                Console.WriteLine($"Saque de {valor:C} realizado com sucesso. Saldo atual: {Saldo:C}");
            }
            else
            {
                Console.WriteLine($"Saldo insuficiente para saque de {valor:C}. Saldo atual: {Saldo:C}");
            }
        }
        //metodo exibir saldo
        public void ExibirSaldo()
        {
            Console.WriteLine($"Saldo da conta {NumeroConta}: {Saldo:C}");
        }
    }
}
