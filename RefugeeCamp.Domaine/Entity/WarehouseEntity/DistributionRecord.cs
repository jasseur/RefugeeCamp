using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RefugeeCamp.Domaine.Entity
{
    public class DistributionRecord
    {
        [Key]
        public int Id { get; set; }
        [Column(TypeName = "datetime2")]
        public DateTime DateDistribution { get; set; }
        public Staff Staff { get; set; }
        public Shelter Shelter { get; set; }

        public virtual ICollection<Lot> Lots { get; set; }
    }
}
