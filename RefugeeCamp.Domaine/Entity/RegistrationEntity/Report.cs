using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RefugeeCamp.Domaine.Entity
{
    public class Report
    {
        [Key]
        public int Id { get; set; }
        public String Object { get; set; }
        public String Body { get; set; }
        [Column(TypeName = "datetime2")]
        public DateTime DateReport { get; set; }

        public virtual Staff Staff { get; set; }
        public virtual Refugee Refugee { get; set; }
    }
}
