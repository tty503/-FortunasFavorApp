namespace AccountService.Models
{
    public class Account
    {
        public Guid Id { get; set; }
        public string Name { get; set; }
        public string Currency { get; set; }

        public decimal Balance { get; set; }

        //public List<User> Owner { get; set; }
    }
}
