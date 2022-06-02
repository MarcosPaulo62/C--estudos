using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Teste_GFT_08_02_2022.Interfaces;

namespace Teste_GFT_08_02_2022.Models
{
    public class VideoGame : Produto, IImposto
    {
        protected string marca;
        protected string modelo;
        protected bool isUsado;

        public VideoGame()
        {
            marca = "";
            modelo = "";
            isUsado = false;
        }

        public VideoGame(string nome, double preco, int qtd, string marca, string modelo, bool isUsado) : base(nome, preco, qtd)
        {
            this.marca = marca;  
            this.modelo = modelo;
            this.isUsado = isUsado;
        }

        public void calculaImposto()
        {
            if (isUsado == true)
                Console.WriteLine($"Imposto {nome} {modelo} usado, R$ {(preco * 0.25).ToString("F1")}.");
            else
                Console.WriteLine($"Imposto {nome} {modelo} R$ {(preco * 0.45).ToString("F1")}.");
        }

        public string Nome
        {
            get { return nome; }
            set { nome = value; }
        }
        public double Preco
        {
            get { return preco; }
            set { preco = value; }
        }
        public int Qtd
        {
            get { return qtd; }
            set { qtd = value; }
        }
        public string Marca
        {
            get { return marca; }
            set { marca = value; }
        }
        public string Modelo
        {
            get { return modelo; }
            set { modelo = value; }
        }
        public bool IsUsado
        {
            get { return isUsado; }
            set { isUsado = value; }
        }
    }
}
