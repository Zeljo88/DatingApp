namespace DatingApp.API.Models
{
    public class User
    {
    
        public int Id { get; set; }
        public string Username { get; set; }
        public byte[] PassowrdHash { get; set; }
        public byte[] PassowrdSalt { get; set; }
    }
}