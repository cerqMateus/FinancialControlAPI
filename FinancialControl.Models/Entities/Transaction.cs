namespace FinancialControl.Models.Entities
{
    public class Transaction
    {
        public int Id { get; set; }
        public  string Description { get; set; }
        public int AmountInCents { get; set; }
        public string? Type { get; set; }
        public DateTime Date {  get; set; } = DateTime.UtcNow;

        public Transaction(string description, int amount_int_cents, string type)
        {
            var random = new Random();
            Id = random.Next(1,1000);
            Description = description;
            AmountInCents = amount_int_cents;
            Type = type;
        }
    }
}
