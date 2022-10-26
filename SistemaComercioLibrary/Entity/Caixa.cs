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
        [MaxLength(255)]
        public string Nome { get; set; }
        [Required]
        [MaxLength(255)]
        public double Saldo { get; set; }


        public virtual List<MovimentoCaixa> MovimentoCaixa { get; set; }
    }
}
