using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RefugeeCamp.Domaine.Entity
{
   public class Treatment
    {
        [Key]
        [Column(Order = 1)]
        public int DrugId { get; set; }
        [Key]
        [Column(Order = 2)]
        public int PrescriptionId { get; set; }
        [Key]
        [Column(Order = 3,TypeName = "datetime2")]
        public DateTime Date { get; set; }

        public String Instruction { get; set; }
        public int Duration { get; set; }

        
        public Supply drug { get; set; }
        public Prescription prescription { get; set; }


    }
}
