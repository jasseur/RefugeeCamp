using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RefugeeCamp.Domaine.Entity
{
    public class Disease
    {
        [Key]
        public int Id { get; set; }
        public String Name { get; set; }

        
        public virtual Classification Classification { get; set; }
        public virtual ICollection<Diagnostic> Diagnostics { get; set; }
    }
}
