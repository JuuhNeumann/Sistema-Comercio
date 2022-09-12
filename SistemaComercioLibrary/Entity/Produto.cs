using SistemaComercioLibrary.Classes;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
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
        [Required]
        public Fornecedor Id_Fornecedor { get; set; }


        public Produto(int id, string nome, int quantidade_Estoque, double preco, int unidade, Fornecedor id_Fornecedor)
        {
            Id = id;
            Nome = nome;
            Quantidade_Estoque = quantidade_Estoque;
            Preco = preco;
            Unidade = unidade;
            Id_Fornecedor = id_Fornecedor;
        }
    }
}
