using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SistemaComercioLibrary.Classes
{
    public class Cliente
    {

        [Key]
        public int Id { get; set; }
        [Required]
        public string Nome { get; set; }
        [Required]
        public string Cpf_Cnpj { get; set; }
        [Required]
        public string Logradouro { get; set; }
        [Required]
        public int Numero { get; set; }
        [Required]
        public string Complemento { get; set; }
        [Required]
        public string Bairro { get; set; }
        [Required]
        public string Cidade { get; set; }
        [Required]
        public string Estado { get; set; }
        [Required]
        public string Cep { get; set; }
        [Required]
        public string Telefone { get; set; }
        [Required]
        public string Email { get; set; }


        public Cliente(int id, string nome, string cpf_Cnpj, string logradouro, int numero, string complemento, string bairro, string cidade, string estado, string cep, string telefone, string email)
        {
            Id = id;
            Nome = nome;
            Cpf_Cnpj = cpf_Cnpj;
            Logradouro = logradouro;
            Numero = numero;
            Complemento = complemento;
            Bairro = bairro;
            Cidade = cidade;
            Estado = estado;
            Cep = cep;
            Telefone = telefone;
            Email = email;
        }
    }
}
