using Microsoft.AspNetCore.Identity;
using System.ComponentModel.DataAnnotations;

namespace Meetup.Models
{
    public class AppUser : IdentityUser
    {
        [MaxLength(50)]
        public string? Fullname { get; set; }
    }
}
