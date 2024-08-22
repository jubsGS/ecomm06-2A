using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ecomm06_2A.Models
{
    [Table("usuario")]
    public class Usuario
    {
        private int id_usuario;
        private string nome;
        private string email;
        private string senha;
        private string telefone;
        private bool admin;


        [Column("id_usuario")]
        public int Id_usuario { get => id_usuario; set => id_usuario = value; }

        [Column("nome")]
        public string Nome{ get => nome; set => nome = value; }

        [Column("email")]
        public string Email{ get => email; set => email = value; }
        
        [Column("senha")]
        public string Senha{ get => senha; set => senha = value; }
        
        [Column("telefone")]
        public string Telefone{ get => telefone; set => telefone = value; }

        [Column("admin")]
        public bool Admin{ get => admin; set => admin = value; }

        public Usuario()
        {
            nome = "";
            email = "";
            senha = "";
            telefone = "";
        }
    }
}
