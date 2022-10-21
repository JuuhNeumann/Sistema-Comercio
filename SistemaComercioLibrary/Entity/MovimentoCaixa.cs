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
        [MaxLength(10, ErrorMessage = "A data de movimento não pode ultrapassar 10 caracteres!")]
        public DateTime Data_Movimento { get; set; }
        [Required]
        [MaxLength(5, ErrorMessage = "A hora não pode ultrapassar 5 caracteres!")]
        public DateTime Hora_Movimento { get; set; }
        [Required]
        [MaxLength(30, ErrorMessage = "A descrição não pode ultrapassar 30 caracteres!")]
        public string Descricao { get; set; }
        [Required]
        [MaxLength(30, ErrorMessage = "O tipo de movimento não pode ultrapassar 30 caracteres!")]
        public string Tipo_Movimento { get; set; }
        [Required]
        [MaxLength(30, ErrorMessage = "O valor não pode ultrapassar 30 caracteres!")]
        public double Valor { get; set; }
        [Required]
        public Caixa Caixa { get; set; }

        public int Id_Caixa { get; set; }

    }
}
