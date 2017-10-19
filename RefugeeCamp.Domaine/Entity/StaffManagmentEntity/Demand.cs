using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RefugeeCamp.Domaine.Entity
{
   public class Demand
    {
        [Key]
        public int Id { get; set; }
        public String Name { get; set; }
        public String Description { get; set; }
        public int Quantity { get; set; }
        public String Unit { get; set; }
        [Column(TypeName = "datetime2")]
        public DateTime Date { get; set; }

        public virtual Supply Supply { get; set; }

    }
}
