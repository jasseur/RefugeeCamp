using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RefugeeCamp.Domaine.Entity
{
   public class Level
    {
        [Key]
        public int Id { get; set; }
        [Required]
        public String LevelName { get; set; }
        [Required]
        public String Description { get; set; }

        public virtual ICollection<Course> Cources { get; set; }

        public virtual ICollection<Student> Students { get; set; }


    }
}
