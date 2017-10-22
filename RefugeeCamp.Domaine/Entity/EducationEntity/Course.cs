using RefugeeCamp.Domaine.Entity;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RefugeeCamp.Domaine.Entity
{
   public class Course
    {   [Key]
        public int Id { get; set; }

        [Required]
        public String Name { get; set; }
        [Required]
        public String Description { get; set; }

        public virtual Level level { get; set; }


    }
}
