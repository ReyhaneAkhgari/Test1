namespace Authentication.Models
{
    public class User:Object
    {
        public User():base() { }

        public int Id { get; set; }
        
        public string Username { get; set; }

        public string LastName { get; set; }

        public string EmailAddress { get; set; }

        [System.Text.Json.Serialization.JsonIgnore]

        public string Password { get;set; }
    }
}
