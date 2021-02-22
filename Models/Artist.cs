using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace DT102G_moment3._2.Models
{
    public class Artist
    {
        public int ArtistId { get; set; }
        [Required(ErrorMessage ="Du måste ange namnet på artisten")]
        [DisplayName("Artist")]
        public string Name { get; set; }

        //Foreign Keys
        public ICollection<Cd> Cds { get; set; }

        public Artist()
        {

        }
    }

}
