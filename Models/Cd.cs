using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel;


namespace DT102G_moment3._2.Models
{
    public class Cd
    {

        [DisplayName("CD skriva")]
        public int CdId { get; set; }
        [DisplayName("Album")]
        [Required]
        public string Title { get; set; }

        [DisplayName("Den är utlånad")]
        public bool Loan { get; set; } = false;

        //Foreign Keys
        [DisplayName("Artist")]
        public int ArtistId { get; set; }
        public Artist Artist { get; set; }

        public ICollection<Loan> Loans { get; set; }
        public Cd()
        {

        }
    }

}
