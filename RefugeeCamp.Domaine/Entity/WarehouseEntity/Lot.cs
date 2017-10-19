using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RefugeeCamp.Domaine.Entity
{
    public class Lot
    {
        [Key]
        public int Id { get; set; }
        public int Quantity { get; set; }
        [Column(TypeName = "datetime2")]
        public DateTime ArrivalDate { get; set; }
        [Column(TypeName = "datetime2")]
        public DateTime ExpiryDate { get; set; }
        public String SentFrom { get; set; }
        [DataType(DataType.ImageUrl)]
        public String Picture { get; set; }

        public virtual Supply TypeLot { get; set; }
        public virtual DistributionRecord DistributionRecord { get; set; }

    }
}
