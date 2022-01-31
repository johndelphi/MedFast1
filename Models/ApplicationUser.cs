
using Microsoft.AspNetCore.Identity;
using System.ComponentModel.DataAnnotations;

namespace MedFast1.Models;
public class ApplicationUser: IdentityUser
{
  [Required]
  [StringLength(100)]
  public string FirstName { get; set; }
  public string LastName { get; set; }

}
