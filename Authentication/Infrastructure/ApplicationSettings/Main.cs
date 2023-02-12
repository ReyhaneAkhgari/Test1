namespace Authentication.Infrastructure.ApplicationSettings
{
    public class Main : Object
    {
        public Main() : base() { }

        public string SecretKey { get; set; }

        public int TokenExpiresInMinutes { get; set; }

    }
}
