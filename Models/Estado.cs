using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace API_TURISMO.Models
{
    [Table("Estado")]
    public class Estado
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int Eid { get; set; }


        [MaxLength(2)]
        public string uf { get; set; }

        [MaxLength(50)]
        public string name { get; set; }

    }
}
