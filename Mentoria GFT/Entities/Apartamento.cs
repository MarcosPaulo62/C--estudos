namespace Mentoria_GFT.Entities
{
    public class Apartamento : Imovel
    {
        public Apartamento(string endereco, string cidade, int metragem, byte qtdQuartos, int valorImovel, byte Andar, string NumeroApartamento, string Torre) : base(endereco, cidade, metragem, qtdQuartos, valorImovel)
        {
            this.Andar = Andar;
            this.NumeroApartamento = NumeroApartamento;
            this.Torre = Torre;
        }

        public byte Andar { get; set; }
        public string NumeroApartamento { get; set; }
        public string Torre { get; set; }

        public override double TaxaCorretor()
        {
            return ValorImovel * 1.2;
        }

        public override string ToString()
        {
            return @$"Cidade: {Cidade}
Endereço: {Endereco}
Metragem: {Metragem}
Quartos: {QtdQuartos}
Andar: {Andar}
Número do Apartamento: {NumeroApartamento}
Torre: {Torre}
Valor do Imóvel: {ValorImovel}
Valor final: {TaxaCorretor()}";
        }
    }
}