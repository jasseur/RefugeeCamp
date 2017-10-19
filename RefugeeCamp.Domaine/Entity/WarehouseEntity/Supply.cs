using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RefugeeCamp.Domaine.Entity
{
    public class Supply
    {
        [Key]
        public int Id { get; set; }
        public String Name { get; set; }
        public String Description { get; set; }
        public TypeSupply TypeSupply { get; set; }

        public virtual ICollection<Demand> Demands { get; set; }
        public virtual ICollection<Treatment> Treatments { get; set; }
    }

    public enum TypeSupply { Food, Drugs, Equipment }
}
