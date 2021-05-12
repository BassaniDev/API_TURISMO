using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace API_TURISMO.Models
{
    public class P_Turistico
    {
        [Key]
        public int Id { get; set; }

        [Column("Nome")]
        [Display(Name = "Nome")]
        [Required(ErrorMessage = "Este campo é obrigatório")]
        [MaxLength(60, ErrorMessage = "Este campo deve conter entre 3 e 60 caracteres")]
        [MinLength(3, ErrorMessage = "Este campo deve conter entre 3 e 60 caracteres")]
        public string Nome { get; set; }

        [Column("Descrição")]
        [Display(Name = "Descrição")]
        [Required(ErrorMessage = "Este campo é obrigatório")]
        [MaxLength(100, ErrorMessage = "Este campo deve conter entre 3 e 100 caracteres")]
        [MinLength(3, ErrorMessage = "Este campo deve conter entre 3 e 100 caracteres")]
        public string Descrição { get; set; }

        [Column("Endereço")]
        [Display(Name = "Endereço")]
        [Required(ErrorMessage = "Este campo é obrigatório")]
        [MaxLength(60, ErrorMessage = "Este campo deve conter entre 3 e 60 caracteres")]
        [MinLength(3, ErrorMessage = "Este campo deve conter entre 3 e 60 caracteres")]
        public string Endereço { get; set; }

        [Column("Estado")]
        [Display(Name = "Estado")]
        [Required(ErrorMessage = "Este campo é obrigatório")]
        public int EstadoId { get; set; }
        public Estado Estado { get; set; }

        [Column("Cidade")]
        [Display(Name = "Cidade")]
        [Required(ErrorMessage = "Este campo é obrigatório")]
        public int CidadeId { get; set; }
        public Cidade Cidade { get; set; }
    }
}
