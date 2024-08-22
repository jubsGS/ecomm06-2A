using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ecomm06_2A.Models
{
    [Table("produto")]
    public class Produto
    {
        private int id_produto;
        private string nome;
        private string descricao;
        private double valor_unitario;
        private bool excluido;
        private DateOnly data_exclusao;
        private int qtde_estoque;
        private string aroma;


        [Column("id_produto")]
        public int Id_produto { get => id_produto; set => id_produto = value; }

        [Column("nome")]
        public string Nome { get => nome; set => nome = value; }

        [Column("descricao")]
        public string Descricao { get => descricao; set => descricao = value; }

        [Column("valor_unitario")]
        public double Valor_unitario { get => valor_unitario; set => valor_unitario = value; }

        [Column("excluido")]
        public bool Excluido { get => excluido; set => excluido = value; }

        [Column("data_exclusao")]
        public DateOnly Data_exclusao { get => data_exclusao; set => data_exclusao = value; }

        [Column("qtde_estoque")]
        public int Qtde_estoque { get => qtde_estoque; set => qtde_estoque = value; }

        [Column("aroma")]
        public string Aroma { get => aroma; set => aroma = value; }

        public Produto()
        {
            nome = "";
            descricao = "";
            aroma = "";
        }
    }
}
