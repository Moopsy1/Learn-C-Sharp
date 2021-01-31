using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace IOU.Models
{
    public class IOUSlip
    {
        public int ID { get; set; }
        public string Owner { get; set; }
        public string Debtor { get; set; }

        [Column(TypeName = "decimal(18, 2)")]
        public decimal Amount { get; set; }

        
    }
}
