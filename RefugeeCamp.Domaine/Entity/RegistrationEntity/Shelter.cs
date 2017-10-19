using RefugeeCamp.Domaine.ComplexType;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RefugeeCamp.Domaine.Entity
{
 public   class Shelter
    {
        [Key]
        public int Id { get; set; }
        public string Name { get; set; }
        public int Capacity { get; set; }

        public virtual ICollection<Family> Familys { get; set; }
        public ICollection<DistributionRecord> DistributionRecords { get; set; }
    }
}
