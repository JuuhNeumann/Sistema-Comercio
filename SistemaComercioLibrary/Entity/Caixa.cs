using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SistemaComercioLibrary.Classes
{
    public class Caixa
    {

        [Key]
        public int Id { get; set; }
        [Required]
        [MaxLength(20, ErrorMessage = "O nome não pode ultrapassar 20 caracteres!")]
        public string Nome { get; set; }
        [Required]
        [MaxLength(50, ErrorMessage = "O saldo não pode ultrapassar 50 caracteres!")]
        public double Saldo { get; set; }


        public List<MovimentoCaixa> MovimentoCaixa { get; set; }
    }
}
