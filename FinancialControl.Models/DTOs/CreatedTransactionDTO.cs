namespace FinancialControl.Models.DTOs
{
    public class CreatedTransactionDTO
    {
        public required string Destription { get; set; }
        public required int AmountInCents { get; set; }
        public required string Type { get; set; }
    }
}
