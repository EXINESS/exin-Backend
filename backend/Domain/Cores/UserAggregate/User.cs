namespace backend.Domain.Cores.UserAggregate
{
    public class User : Entity<int>
    {
        public int Id { get; set; }
        public string Username { get; set; }
        public string Password { get; set; }
        public int N { get; set; }
    }
}
