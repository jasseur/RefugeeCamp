using RefugeeCamp.Domaine.Entity;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RefugeeCamp.Domaine.Entity
{
   public class Course
    {   [Key]
        public int CourseId { get; set; }

        [Required]
        public String Name { get; set; }
        [Required]
        public String Description { get; set; }


        //fk
        public int? LevelId { get; set;  }
        [ForeignKey("LevelId")]
        public virtual Level level { get; set; }



    }
}
