using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SistemaComercioLibrary.Classes
{
    public class Venda
    {

        [Key]
        public int Id { get; set; }
        [Required]
        public DateTime Data { get; set; }
        [Required]
        public DateTime Hora { get; set; }
        [Required]
        public double Total_Venda { get; set; }
        [Required]
        public string Situacao_Venda { get; set; }
        [Required]
        public Cliente Id_Cliente { get; set; }


        public Venda(int id, DateTime data, DateTime hora, double total_Venda, string situacao_Venda, Cliente id_Cliente)
        {
            Id = id;
            Data = data;
            Hora = hora;
            Total_Venda = total_Venda;
            Situacao_Venda = situacao_Venda;
            Id_Cliente = id_Cliente;
        }
    }
}
