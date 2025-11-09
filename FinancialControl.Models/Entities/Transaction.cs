namespace FinancialControl.Models.Entities
{
    public class Transaction
    {
        public int Id { get; set; }
        public required string Description { get; set; }
        public required int AmountInCents { get; set; }
        public string? Type { get; set; }
        public DateTime Date {  get; set; } = DateTime.UtcNow;
    }
}
