namespace Tryitter_RD.Domains
{
    public class User
    {
        public string Email { get; set; }
        public string UserName { get; set; }
        public string Password { get; set; }
        
        public User(string email, string userName, string passowrd) 
        { 
            Email = email;
            UserName = userName;
            Password = passowrd;
        }
    }
}
