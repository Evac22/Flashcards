
using Microsoft.AspNetCore.Identity;


namespace Flashcards.Core.Entities;

public class ApplicationUser : IdentityUser
{
    public string FullName {  get; set; }
}
