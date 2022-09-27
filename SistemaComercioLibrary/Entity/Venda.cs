using SistemaComercioLibrary.Entity;
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
        public Cliente Cliente { get; set; }
       
        public int Id_Cliente { get; set; }
        public List<FormaPagamentoVenda> FormaPagamentoVenda { get; set; }
       
        public List<ItemVenda> ItemVenda { get; set; }

        public ContaReceber ContaReceber { get; set; }
    }
}
