using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SistemaComercioLibrary.Classes
{
    public class Venda
    {

        public int Id { get; set; }
        public DateTime Data { get; set; }
        public DateTime Hora { get; set; }
        public double Total_Venda { get; set; }
        public string Situacao_Venda { get; set; }


        public Venda(int id, DateTime data, DateTime hora, double total_Venda, string situacao_Venda)
        {
            Id = id;
            Data = data;
            Hora = hora;
            Total_Venda = total_Venda;
            Situacao_Venda = situacao_Venda;
        }
    }
}
