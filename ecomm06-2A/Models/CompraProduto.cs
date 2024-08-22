using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ecomm06_2A.Models
{
    [Table("compra_produto")]
    internal class CompraProduto
    {
        private int quantidade;
        private double valor_unitario;

        [Column("quantidade")]
        public int Quantidade { get => quantidade; set => quantidade = value; }

        [Column("valor_unitario")]
        public double Valor_unitario { get => valor_unitario  ; set => valor_unitario = value; }

        [ForeignKey("id_compra")]
        public virtual Compra Compra { get; set; }

        [ForeignKey("id_produto")]
        public virtual Produto Produto { get; set; }
        
        public CompraProduto()
        {
            Compra = new Compra();
            Produto = new Produto();
        }
    }
}
