using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SistemaComercioLibrary.Classes
{
    public class Caixa
    {
     
        public int Id { get; set; }
        public string Nome { get; set; }
        public double Saldo { get; set; }

        public Caixa(int id, string nome, double saldo)
        {
            Id = id;
            Nome = nome;
            Saldo = saldo;
        }
    }
}
