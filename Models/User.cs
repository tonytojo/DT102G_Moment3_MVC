using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;

namespace DT102G_ASP_NET_Moment3.Models
{
    public class User
    {
        public int UserId { get; set; }

        [Required]
        public string Name { get; set; }

        [Required]
        public DateTime RentedWhen { get; set; } = DateTime.Now;

        //Navigation reference, Foreign key
        //We relation one-one bwtween user and Record(CD)
        public virtual Record Record { get; set; }
        public int? RecordId { get; set; }
    }
}
