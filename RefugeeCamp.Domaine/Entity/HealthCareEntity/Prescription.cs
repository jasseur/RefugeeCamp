using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RefugeeCamp.Domaine.Entity
{
    public class Prescription
    {
        [Key]
        [Column(Order = 1)]
        public int PatientId { get; set; }
        [Key]
        [Column(Order = 2)]
        public int DoctorId { get; set; }
        [Key]
        [Column(Order = 3,TypeName = "datetime2")]
        public DateTime Date { get; set; }

        public String Note { get; set; }
    

        public virtual Patient Patient { get; set; }
        public virtual Doctor Doctor { get; set; }
        public virtual ICollection<Treatment> Treatments { get; set; }
    }
}
