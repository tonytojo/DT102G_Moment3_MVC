using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace DT102G_ASP_NET_Moment3.Models
{
    public class Record
    {
        public int RecordId { get; set; }

        [Required]
        public string Name { get; set; }

        [Required]
        public int ReleasedYear { get; set; }

        public int NrOfTunes { get; set; }
        public int TotalLength { get; set; }
        public DateTime Created { get; set; } = DateTime.Now;

        //Navigation reference, Foreign key
        public virtual Artist Artist { get; set; }
        public int ArtistId { get; set; }
    }
}
