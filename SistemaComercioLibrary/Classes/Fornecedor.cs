using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SistemaComercioLibrary.Classes
{
    public class Fornecedor
    {

        public int Id { get; set; }
        public string Nome { get; set; }
        public string Cpf_Cnpj { get; set; }
        public string Logradouro { get; set; }
        public int Numero { get; set; }
        public string Complemento { get; set; }
        public string Bairro { get; set; }
        public string Cidade { get; set; }
        public string Estado { get; set; }
        public string Cep { get; set; }
        public string Telefone { get; set; }
        public string Email { get; set; } //usuário login
        public string Senha { get; set; } //senha login



        public Fornecedor(int id, string nome, string cpf_Cnpj, string logradouro, int numero, string complemento, string bairro, string cidade, string estado, string cep, string telefone, string email, string senha)
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
            Senha = senha;
        }
    }
}
