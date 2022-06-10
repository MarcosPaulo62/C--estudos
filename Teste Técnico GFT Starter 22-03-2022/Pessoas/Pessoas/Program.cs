/*Crie uma Classe Pessoa, contendo os atributos (nome, endereço e telefone) 
encapsulados, com seus respectivos seletores (getters) e modificadores(setters), e
ainda o construtor padrão. Por fim, criar uma classe principal que instancie o objeto 
Pessoa, adicione no mínimo um valor para cada atributo e imprima na tela.*/

using Pessoas.Models;

Pessoa p1 = new("Andrew", "São Paulo - SP", "011981234567");

Pessoa p2 = new Pessoa("João", "Salvador - BA", "071999999999");

Pessoa p3 = new Pessoa();
p3.Nome = "Pedro";
p3.Endereco = "Belo Horizonte - MG";
p3.Telefone = "031988889999";

p1.Apresentar();
p2.Apresentar();
p3.Apresentar();
