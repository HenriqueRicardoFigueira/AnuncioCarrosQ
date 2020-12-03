using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;


/* (Modelo, Marca, Ano, Valor de Compra, Valor de Venda, Cor, Tipo Combustível,  Data de Venda).*/
namespace GerenciadorDeAnuncio.Models
{
    public class Anuncio
    {
        public long Id { get; set; }
        public virtual Marca Marca { get; set; }
        public virtual Modelo Modelo { get; set; }
        public long MarcaId { get; set; }
        public long ModeloId { get; set; }
        public int Ano { get; set; }
        public decimal ValorDeCompra { get; set; }
        public decimal ValorDeVenda { get; set; }
        public string Cor { get; set; }
        public string TipoCombustivel { get; set; }
        public DateTime DataVenda { get; set; }

    }
}
