using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace RefugeeCamp.Domaine.Entity
{
  public  class Refugee
    {   [Key]
        public int Id { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string MaritalStatus { get; set; }
        [Column(TypeName = "datetime2")]
        public DateTime BirthDate { get; set; }
        [Column(TypeName = "datetime2")]
        public DateTime RegistrationDate { get; set; }

        public virtual Family Family { get; set; }
        public virtual ICollection<Report> Reports { get; set; }

        //   public virtual Family Family { get; set; }
    }
}
