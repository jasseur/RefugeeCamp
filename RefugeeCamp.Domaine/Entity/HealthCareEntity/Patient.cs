using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RefugeeCamp.Domaine.Entity
{
    public class Patient : Refugee
    {
        [Column(TypeName = "datetime2")]
        public DateTime RegistrationDate { get; set; }


        public virtual ICollection<Appointment> Appointments { get; set; }
        public virtual ICollection<Prescription> Prescriptions { get; set; }
        public virtual ICollection<Diagnostic> Diagnostics { get; set; }

        //  public List<Allergie> Allergies { get; set; }
    }
}
