using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RefugeeCamp.Domaine.Entity
{
  public  class Classsroom
    {
        [Key]
        public int Id { get; set; }
        [Required]
        [Column(TypeName = "datetime2")]
        public DateTime Start { get; set; }
        [Required]
        [Column(TypeName = "datetime2")]
        public DateTime Finish { get; set; }

        public String ClassroomName { get; set; }
        public String ClassroomDescription { get; set; }



        //fk
        [Required]
        public int? StaffId { get; set; }
        [ForeignKey("StaffId")]
        public virtual Teacher Teacher { get; set; }

        //fk
        [Required]
        public int? LevelId { get; set; }
        [ForeignKey("LevelId")]
        public virtual Level Level { get; set; }





    }
}
