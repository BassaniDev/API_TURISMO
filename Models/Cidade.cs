using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace API_TURISMO.Models
{
    [Table("Cidade")]
    public class Cidade
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int Cid { get; set; }

        public int Eid { get; set; }
        public Estado Estado { get; set; }

        [MaxLength(2)]
        public string uf { get; set; }

        [MaxLength(50)]
        public string name { get; set; }

    }
}
