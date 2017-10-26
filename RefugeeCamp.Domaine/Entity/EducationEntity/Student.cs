using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace RefugeeCamp.Domaine.Entity
{
    public class Student : Refugee
    {

        [Required]
        public String Notes { get; set; }

        //fk
        public int? LevelId { get; set; }
        [ForeignKey("LevelId")]
        public virtual Level level { get; set; }

        public virtual ICollection<Classsroom> Classsrooms { get; set; }


    }
}
