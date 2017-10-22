using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RefugeeCamp.Domaine.ComplexType
{

    public class Contact


    {
        [Required]
        public String PhoneNumber { get; set; }
        [Required]
        public String Adress { get; set; }
        [Required]
        public String Email { get; set; }
    }
}
