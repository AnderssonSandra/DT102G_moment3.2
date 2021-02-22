using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel;

namespace DT102G_moment3._2.Models
{
    [DisplayName("Utlånging")]

    public class Loan
    {
        public int LoanId { get; set; }

        [Required(ErrorMessage ="Du måste ange namnet på den som lånat skivan")]
        [DisplayName("Namn på den som lånat skivan")]
        public string Borrower { get; set; }

        [DisplayName("Datum för när skivan lånades ut")]
        [Required(ErrorMessage = "Du måste ange datum")]
        public DateTime LoanDate { get; set; } = DateTime.Now;

        //Foreign Keys
        [DisplayName("Album")]
        public int CdId { get; set; }
        public Cd Cd { get; set; }

        public Loan()
        {


        }
    }
}
