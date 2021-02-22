using Microsoft.AspNetCore.Mvc.Rendering;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace DT102G_ASP_NET_Moment3.Models
{
    public class Artist
    {
        public int ArtistId { get; set; }

        [Required]
        public string Name { get; set; }

        [Required]
        public int Age { get; set; }

        public string Gender { get; set; }

        [Required]
        public string Url { get; set; }

        [Required]
        public int Salary { get; set; }

        public DateTime Created { get; set; } = DateTime.Now;

        //Navigation collection
        public virtual ICollection<Record> Records { get; set; }
    }
}
