
using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
namespace Bidmaster2.Models
{
    public class Transaction
    {
        [Key]
        public int TransactionID { get; set; }


        public int BuyerID { get; set; }


        public int AuctionID { get; set; }

        [Column(TypeName = "decimal(18,2)")]
        public decimal Amount{get; set;}


      


        public string? PaymentStatus { get; set; }


        public DateTime PaymentDate { get; set; }

    }
}
