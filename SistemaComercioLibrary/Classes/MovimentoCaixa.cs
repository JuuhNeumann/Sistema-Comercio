using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SistemaComercioLibrary.Classes
{
    public class MovimentoCaixa
    {

        public int Id { get; set; }
        public DateTime Data_Movimento { get; set; }
        public DateTime Hora_Movimento { get; set; }
        public string Descricao { get; set; }
        public string Tipo_Movimento { get; set; }
        public double Valor { get; set; }


        public MovimentoCaixa(int id, DateTime data_Movimento, DateTime hora_Movimento, string descricao, string tipo_Movimento, double valor)
        {
            Id = id;
            Data_Movimento = data_Movimento;
            Hora_Movimento = hora_Movimento;
            Descricao = descricao;
            Tipo_Movimento = tipo_Movimento;
            Valor = valor;
        }
    }
}
