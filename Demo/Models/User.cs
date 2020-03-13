using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace Demo.Models
{
    public class User
    {
        [Key]
        public int ID { get; set; }

        [Required]
        [StringLength(50, MinimumLength = 4)]
        [Display(Name = "Primeiro Nome")]
        public string PrimeiroNome { get; set; }

        [Required]
        [StringLength(50, MinimumLength = 4)]
        [Display(Name = "Último Nome")]
        public string UltimoNome { get; set; }

        [Required]
        [StringLength(10, ErrorMessage = "Permitido no máximo 10 caracteres")]
        [Display(Name = "Nome de Usuário")]
        public string Login { get; set; }

        [DataType(DataType.Date)]
        [DisplayFormat(DataFormatString = "{0:dd/MM/yyyy}", ApplyFormatInEditMode = true)]
        [Display(Name = "Data de nascimento")]
        public DateTime DataNascimento { get; set; }

        [Required]
        [StringLength(40, ErrorMessage = "Permitido no máximo 40 caracteres")]
        [Display(Name = "Email")]
        public string Email { get; set; }

        [StringLength(14, ErrorMessage ="Permitido no máximo 14 caracteres")]
        [Display(Name = "Telefone")]
        public string Telefone { get; set; }
    }
}
