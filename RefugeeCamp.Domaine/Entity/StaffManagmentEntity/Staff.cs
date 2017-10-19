using RefugeeCamp.Domaine.ComplexType;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RefugeeCamp.Domaine.Entity
{
   public class Staff
    {
        [Key]
        public int Id { get; set; }

        public String FirstName { get; set; }
        public String LastName { get; set; }
        [Column(TypeName = "datetime2")]
        public DateTime BirthDate { get; set; }
        [Column(TypeName = "datetime2")]
        public DateTime HireDate { get; set; }
        public Gender Gender { get; set; }
        public Contact Contact { get; set; }
        public Role Role { get; set; }

        public ICollection<DistributionRecord> DistributionRecords { get; set; }


    }
}
