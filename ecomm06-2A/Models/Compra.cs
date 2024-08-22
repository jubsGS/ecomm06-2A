using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace ecomm06_2A.Models
{
    [Table("compra")]
    public class Compra
    {
        private int id_compra;
        private string status;
        private DateOnly data;
        private double acrescimo_total;
        private string id_transacao;
        private string sessao;

        [Column("id_compra")]
        public int Id_compra { get => id_compra; set => id_compra = value; }
        
        [Column("status")]
        public string Status { get => status; set => status = value; }

        [Column("data")]
        public DateOnly Data{ get => data; set => data = value; }

        [Column("acrescimo_total")]
        public double Acrescimo_total { get => acrescimo_total; set => acrescimo_total= value; }

        [Column("id_transacao")]
        public string Id_transacao{ get => id_transacao; set => id_transacao= value; }

        [Column("sessao")]
        public string Sesssao { get => sessao; set => sessao = value; }

        [ForeignKey("id_usuario")]
        public virtual Usuario Usuario { get; set; } 

        public Compra()
        {
            status = "";
            id_transacao = "";
            sessao = "";
            Usuario = new Usuario();
        }
    }
}
