using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel;

namespace DT102G_moment3._2.Models
{
    public class Loan
    {
        public int LoanId { get; set; }

        [Required]
        [DisplayName("Namn på den som lånat skivan")]
        public string Borrower { get; set; }

        [DisplayName("Datum för när skivan lånades ut")]
        public DateTime LoanDate { get; set; } = DateTime.Now;

        //Foreign Keys
        public int CdId { get; set; }
        public Cd Cd { get; set; }

        public Loan()
        {


        }
    }
}
