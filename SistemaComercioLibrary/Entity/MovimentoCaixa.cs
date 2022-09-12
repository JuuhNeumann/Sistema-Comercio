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
        public DateTime Data_Movimento { get; set; }
        [Required]
        public DateTime Hora_Movimento { get; set; }
        [Required]
        public string Descricao { get; set; }
        [Required]
        public string Tipo_Movimento { get; set; }
        [Required]
        public double Valor { get; set; }
        [Required]
        public Caixa Id_Caixa { get; set; }


        public MovimentoCaixa(int id, DateTime data_Movimento, DateTime hora_Movimento, string descricao, string tipo_Movimento, double valor, Caixa id_Caixa)
        {
            Id = id;
            Data_Movimento = data_Movimento;
            Hora_Movimento = hora_Movimento;
            Descricao = descricao;
            Tipo_Movimento = tipo_Movimento;
            Valor = valor;
            Id_Caixa = id_Caixa;
        }
    }
}
