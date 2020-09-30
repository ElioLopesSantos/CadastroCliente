using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace CadastroCliente.Models.Model
{
    [Table("Cliente")]
    public class ClienteModel
    {
        [Key]
        public int ClienteId { get; set; }
        public string Nome { get; set; }
        public int CPF { get; set; }
        public string Email { get; set; }
    }
}