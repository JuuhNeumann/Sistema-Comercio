using SistemaComercioLibrary.Classes;
using SistemaComercioLibrary.Entity;
using SistemaComercioLibrary.Port;
using SistemaComercioLibrary.Service;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace SistemaComercioBiblioteca.Classes
{

    public class Produto
    {

        [Key]
        public int Id { get; set; }
        [Required]
        [MaxLength(30, ErrorMessage = "O nome não pode ultrapassar 30 caracteres!")]
        public string Nome { get; set; }
        [Required]
        [MaxLength(10, ErrorMessage = "A quantidade em estoque não pode ultrapassar 10 caracteres!")]
        public int Quantidade_Estoque { get; set; }
        [Required]
        [MaxLength(30, ErrorMessage = "O preço não pode ultrapassar 30 caracteres!")]
        public double Preco { get; set; }
        [Required]
        [MaxLength(1, ErrorMessage = "A unidade não pode ultrapassar 1 caracteres!")]
        public string Unidade { get; set; }

        public Fornecedor Fornecedor { get; set; }
        public int Id_Fornecedor { get; set; }
        public List<ItemVenda> ItemVenda { get; set; }
        public List<ItemCompra> ItemCompra { get; set; }

    }
}
