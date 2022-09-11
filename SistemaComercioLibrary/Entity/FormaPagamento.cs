using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SistemaComercioLibrary.Classes
{
    public class FormaPagamento
    {

        [Key]
        public int Id { get; set; }
        [Required]
        public string Nome { get; set; }


        public FormaPagamento(int id, string nome)
        {
            Id = id;
            Nome = nome;
        }
    }
}
