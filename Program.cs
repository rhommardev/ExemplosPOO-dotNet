using ExemplosPOO.Models;

ContaCorrente c1 = new ContaCorrente(12345, 1000);

c1.ExibirSaldo();
c1.Sacar(200);
c1.ExibirSaldo();