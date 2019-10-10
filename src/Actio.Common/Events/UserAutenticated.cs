namespace Actio.Common.Events
{
    public class UserAutenticated : IEvent
    {
        public string Email { get; }
        protected UserAutenticated() { }
        public UserAutenticated(string email)
        {
            Email = email;
        }
    }
}