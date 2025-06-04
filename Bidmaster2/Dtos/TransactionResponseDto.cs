namespace Bidmaster2.Dtos
{
    public class TransactionResponseDto
    {
        public int TransactionID { get; set; }
        public int BuyerID { get; set; }
        public int AuctionID { get; set; }
        public decimal Amount { get; set; }
        public string? PaymentStatus { get; set; }
        public DateTime PaymentDate { get; set; }
    }
}
