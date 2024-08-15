using Microsoft.AspNetCore.Identity;

namespace JwtAuthApi.Models;

public class User : IdentityUser
{
    public string Name { get; set; } 
}
