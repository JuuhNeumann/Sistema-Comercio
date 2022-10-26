using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SistemaComercioLibrary.Classes
{
    public class MovimentoCaixa
    {

        [Key]
        public int Id { get; set; }
        [Required]
        [MaxLength(10)]
        public DateTime Data_Movimento { get; set; }
        [Required]
        [MaxLength(5)]
        public DateTime Hora_Movimento { get; set; }
        [Required]
        [MaxLength(255)]
        public string Descricao { get; set; }
        [Required]
        [MaxLength(255)]
        public string Tipo_Movimento { get; set; }
        [Required]
        [MaxLength(255)]
        public double Valor { get; set; }
        [Required]
        public virtual Caixa Caixa { get; set; }

        public int Id_Caixa { get; set; }

    }
}
