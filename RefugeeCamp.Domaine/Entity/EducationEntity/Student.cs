using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace RefugeeCamp.Domaine.Entity
{
    public class Student : Refugee
    {

        [Required]
        public String Notes { get; set; }
  
        public virtual Level Level { get; set; }

        public virtual ICollection<Classsroom> Classsrooms { get; set; }


    }
}
