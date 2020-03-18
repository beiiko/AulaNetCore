using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace Loja.Models
{
    public class FornecedorViewModel
    {
        [Key]
        public int ID { get; set; }

        [Required(ErrorMessage = "Campo Nome Fantasia é obrigatório")]
        [StringLength(50, ErrorMessage = "Limite máximo de 50 caracteres.")]
        [MinLength(5, ErrorMessage = "Limite minimo é 5 caracteres.")]
        [Display(Name = "Nome de Fantasia")]
        public string NomeFantasia { get; set; }

        [Required(ErrorMessage = "Campo Nome é obrigatório")]
        [StringLength(50, ErrorMessage = "Limite máximo de 50 caracteres.")]
        [MinLength(5, ErrorMessage = "Limite minimo é 5 caracteres.")]
        [Display(Name = "Razão Social")]
        public string RazaoSocial { get; set; }

        [Required(ErrorMessage = "Campo Documento é obrigatório")]
        [StringLength(14, ErrorMessage = "Limite máximo de 14 caracteres.")]
        [MinLength(11, ErrorMessage = "Limite minimo é 11 caracteres.")]
        [Display(Name = "CNPJ")]
        public string Documento { get; set; }

        [StringLength(60, ErrorMessage = "Limite máximo de 60 caracteres.")]
        [MinLength(5, ErrorMessage = "Limite minimo é 5 caracteres.")]
        public string Email { get; set; }

        [StringLength(14, ErrorMessage = "Limite máximo de 14 caracteres.")]
        [MinLength(5, ErrorMessage = "Limite minimo é 8 caracteres.")]
        public string Telefone { get; set; }

        [Required(ErrorMessage = "Campo CEP é obrigatório")]
        [StringLength(8, ErrorMessage = "Limite máximo de 8 caracteres.")]
        public string CEP { get; set; }

        [Required(ErrorMessage = "Campo Endereço é obrigatório")]
        [StringLength(80, ErrorMessage = "Limite máximo de 80 caracteres.")]
        public string Endereco { get; set; }

        [Required(ErrorMessage = "Campo Nº do Endereço é obrigatório")]
        [StringLength(8, ErrorMessage = "Limite máximo de 8 caracteres.")]
        public string NumeroEndereco { get; set; }

        [StringLength(30, ErrorMessage = "Limite máximo de 30 caracteres.")]
        [MinLength(5, ErrorMessage = "Limite minimo é 5 caracteres.")]
        public string Complemento { get; set; }


    }
}
