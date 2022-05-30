namespace Mentoria_GFT.Entities
{
    public class Imovel
    {
        public string Endereco { get; set; }
        public string Cidade { get; set; }
        public int Metragem { get; set; }
        public byte QtdQuartos { get; set; }
        public int ValorImovel { get; set; }

        public Imovel(string endereco, string cidade, int metragem, byte qtdQuartos, int valorImovel)
        {
            this.Endereco = endereco;
            this.Cidade = cidade;
            this.Metragem = metragem;
            this.QtdQuartos = qtdQuartos;
            this.ValorImovel = valorImovel;
        }

        public virtual double TaxaCorretor()
        {
            return ValorImovel * 1.1;
        }

        public override string ToString()
        {
            return @$"Cidade: {Cidade}
Endereço: {Endereco}
Metragem: {Metragem}
Quartos: {QtdQuartos}
Valor do Imóvel: {ValorImovel}
Valor final: {TaxaCorretor()}";
        }
    }
}