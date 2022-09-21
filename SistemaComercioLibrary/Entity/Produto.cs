using SistemaComercioLibrary.Classes;
using SistemaComercioLibrary.Entity;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Text.Json.Serialization;
using System.Threading.Tasks;

namespace SistemaComercioBiblioteca.Classes {

    public class Produto{

        [Key]
        public int Id { get; set; }
        [Required]
        public string Nome { get; set; }
        [Required]
        public int Quantidade_Estoque { get; set; }
        [Required]
        public double Preco { get; set; }
        [Required]
        public int Unidade { get; set; }
        public Fornecedor Fornecedor { get; set; }

        public int Id_Fornecedor { get; set; }
        public List<ItemVenda> ItemVenda { get; set; }
        public List<ItemCompra> ItemCompra { get; set; }

    }
}
