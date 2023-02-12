namespace Authentication.Models;
using System.ComponentModel.DataAnnotations;

public class AuthenticateModel
{
    public long Id { get; set; }
    [Required]
    public string Username { get; set; }

    [Required]
    public string Password { get; set; }
}
