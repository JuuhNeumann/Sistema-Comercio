using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
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
        [MaxLength(30, ErrorMessage = "O nome não pode ultrapassar 30 caracteres!")]
        public string Nome { get; set; }
        [Required]
        [Index(IsUnique = true)]
        [MaxLength(18, ErrorMessage = "O CPF/CNPJ não pode ultrapassar 18 caracteres!")]
        public string Cpf_Cnpj { get; set; }
        [Required]
        [MaxLength(30, ErrorMessage = "O logradouro não pode ultrapassar 30 caracteres!")]
        public string Logradouro { get; set; }
        [Required]
        [MaxLength(4, ErrorMessage = "O número não pode ultrapassar 4 caracteres!")]
        public int Numero { get; set; }
        [Required]
        [MaxLength(20, ErrorMessage = "O complemento não pode ultrapassar 20 caracteres!")]
        public string Complemento { get; set; }
        [Required]
        [MaxLength(20, ErrorMessage = "O bairro não pode ultrapassar 20 caracteres!")]
        public string Bairro { get; set; }
        [Required]
        [MaxLength(20, ErrorMessage = "A cidade não pode ultrapassar 20 caracteres!")]
        public string Cidade { get; set; }
        [Required]
        [MaxLength(20, ErrorMessage = "O estado não pode ultrapassar 20 caracteres!")]
        public string Estado { get; set; }
        [Required]
        [MaxLength(9, ErrorMessage = "O CEP não pode ultrapassar 9 caracteres!")]
        public string Cep { get; set; }
        [Required]
        [MaxLength(13, ErrorMessage = "O telefone não pode ultrapassar 13 caracteres!")]
        public string Telefone { get; set; }
        [Required]
        [MaxLength(30, ErrorMessage = "O email não pode ultrapassar 30 caracteres!")]
        public string Email { get; set; }

        public List<ContaReceber> ContaReceber  { get; set; }
        public List<Venda> Venda { get; set; }
    }
}
