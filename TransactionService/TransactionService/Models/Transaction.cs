namespace TransactionService.Models
{
    public class Transaction
    {
        public Guid Id { get; set; }
        public DateTime Created {  get; set; }
        public string Type { get; set; } // Ingreso, Gasto, Transferencia a otra cuenta contable (hacer con un enum)
        public string Description { get; set; }
        public decimal Amount { get; set; }

        // NULL si no aplica (ID de la cuenta destino)
        public Guid DestAccountId { get; set; }
        // Id de la cuenta del propietario 
        public Guid AccountId { get; set; }
        
    }
}
