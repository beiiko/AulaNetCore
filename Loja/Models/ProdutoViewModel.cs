using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace Loja.Models
{
    public class ProdutoViewModel
    {
        [Key]
        public int ID { get; set; }
        [Required(ErrorMessage = "Campo Nome é obrigatório.")]
        [StringLength(40, ErrorMessage = "Limite de 40 caracteres.")]
        [MinLength(3, ErrorMessage = "Limite minimo de 3 caracteres.")]
        public string Nome { get; set; }

        [Required(ErrorMessage = "Campo Descrição é obrigatório.")]
        [StringLength(256, MinimumLength = 5, ErrorMessage = "Limite de 256 caracteres.")]
        public string Descricao { get; set; }

        [DataType(DataType.Date)]
        [DisplayFormat(DataFormatString = "{0:dd/MM/yyyy}", ApplyFormatInEditMode = true )]
        [Display(Name = "Data de validade")]
        public DateTime DataValidade { get; set; }

        [Required(ErrorMessage = "Campo Valor é obrigatótio.")]
        [Display(Name = "Valor unitário")]
        public double Valor { get; set; }

        [Display(Name = "Quantidade")]
        public string Estoque { get; set; }
    }
}
