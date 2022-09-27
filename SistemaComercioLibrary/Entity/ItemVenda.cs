using SistemaComercioBiblioteca.Classes;
using SistemaComercioLibrary.Classes;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SistemaComercioLibrary.Entity
{
    public class ItemVenda
    {
        [Key]
        public int Id { get; set; }
        public int numero_item { get; set; }
        public int quantidade { get; set; }
        public Venda Venda { get; set; }
        public int Id_Venda { get; set; }
        public Produto Produto { get; set; }
        public int Id_Produto { get; set; }
        public double valorUnitario { get; set; }
        public double valorTotal { get; set; }
    }
}
