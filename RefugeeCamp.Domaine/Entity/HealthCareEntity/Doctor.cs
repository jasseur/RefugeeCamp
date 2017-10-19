using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RefugeeCamp.Domaine.Entity
{
    public class Doctor : Staff
    {   
        public String Specialty { get; set; }

       public virtual ICollection<Appointment> Appointments { get; set; }
       public virtual ICollection<Prescription> Prescriptions { get; set; }
       public virtual ICollection<Diagnostic> Diagnostics { get; set; }
    }
}
