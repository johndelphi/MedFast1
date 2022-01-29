
using Microsoft.AspNetCore.Identity;

namespace MedFast1.Models;
public class ApplicationUser: IdentityUser
{
  public string FirstName { get; set; }
  public string LastName { get; set; }

}
