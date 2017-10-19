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
    public class Appointment
    {
        [Key]
        [Column(Order =1)]
        public int DoctorId { get; set; }
        [Key]
        [Column(Order= 2)]
        public int PatientId { get; set; }
        [Key]
        [Column(Order =3 , TypeName = "datetime2")]
        public DateTime DateAppointment { get; set; }

        public String AppointmentType { get; set; }
        [Column(TypeName = "datetime2")]
        public DateTime DateRgistration { get; set; }

        public virtual Doctor Doctor { get; set; }
        public virtual Patient Patient { get; set; }
    }
}
