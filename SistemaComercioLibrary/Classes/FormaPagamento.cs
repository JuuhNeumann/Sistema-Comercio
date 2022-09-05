using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SistemaComercioLibrary.Classes
{
    public class FormaPagamento
    {

        public int Id { get; set; }
        public string Nome { get; set; }


        public FormaPagamento(int id, string nome)
        {
            Id = id;
            Nome = nome;
        }
    }
}
