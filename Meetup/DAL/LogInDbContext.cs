using Meetup.Models;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;

namespace Meetup.DAL
{
    public class LoginDbContext : IdentityDbContext<AppUser>
    {
        public LoginDbContext(DbContextOptions options) : base(options)
        {
        }
    }
}

