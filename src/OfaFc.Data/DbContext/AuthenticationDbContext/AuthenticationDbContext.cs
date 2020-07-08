using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using OfaFc.Data.Entities;

namespace OfaFc.Data.DbContext.AuthenticationDbContext
{
    public class AuthenticationDbContext : IdentityDbContext<ApplicationUser>
    {
        public AuthenticationDbContext(DbContextOptions<AuthenticationDbContext> options) 
        : base(options)
        {

        }
        
    }
}