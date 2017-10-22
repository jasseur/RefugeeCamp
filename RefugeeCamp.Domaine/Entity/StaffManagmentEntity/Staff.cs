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
        [Required]
        public String FirstName { get; set; }
        [Required]
        public String LastName { get; set; }
        [Required]
        [Column(TypeName = "datetime2")]
        public DateTime BirthDate { get; set; }
        [Required]
        [Column(TypeName = "datetime2")]
        public DateTime HireDate { get; set; }
        [Required]
        public Gender Gender { get; set; }
        public Contact Contact { get; set; }
        [Required]
        public Role Role { get; set; }

        public ICollection<DistributionRecord> DistributionRecords { get; set; }


    }
}
