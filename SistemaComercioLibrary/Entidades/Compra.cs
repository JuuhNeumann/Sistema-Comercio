using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SistemaComercioLibrary.Classes
{
    public class Compra
    {
       
        public int Id { get; set; }
        public DateTime Data { get; set; }
        public DateTime Hora { get; set; }
        public double Total_Compra { get; set; }
        public string Situacao_Compra { get; set; }

        public Compra(int id, DateTime data, DateTime hora, double total_Compra, string situacao_Compra)
        {
            Id = id;
            Data = data;
            Hora = hora;
            Total_Compra = total_Compra;
            Situacao_Compra = situacao_Compra;
        }
    }
}
