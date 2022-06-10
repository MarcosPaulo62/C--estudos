/*Considerando os conceitos de Orientação a Objetos, crie uma classe abstrata Pai de 
nome Conta com os seguintes atributos (número, titular e saldo) e mais duas classes 
Filhas (ContaCorrente e ContaPoupanca). Na classe Conta deve existir um método 
de nome rendimento que retorna o rendimento mensal da conta, nas classes filhas 
deve existir o mesmo método rendimento, porém com as seguintes regras: 

⦁ Para ContaCorrente, o método rendimento deve retornar o saldo * 0.03; 
⦁ Para ContaPoupanca, o método rendimento deve retornar o saldo * 0.05;*/

using Banco.Models;

ContaCorrente corrente = new ContaCorrente(1001, "Joel", 10000);

ContaPoupanca poupanca = new ContaPoupanca(1502, "Abigail", 10000);

corrente.Imprimir();
poupanca.Imprimir();
