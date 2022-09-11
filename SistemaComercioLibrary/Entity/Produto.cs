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
        public string Nome { get; set; }
        public int Quantidade_Estoque { get; set; }
        public double Preco { get; set; }
        public int Unidade { get; set; }


        public Produto(int id, string nome, int quantidade_Estoque, double preco, int unidade)
        {
            Id = id;
            Nome = nome;
            Quantidade_Estoque = quantidade_Estoque;
            Preco = preco;
            Unidade = unidade;
        }
    }
}
