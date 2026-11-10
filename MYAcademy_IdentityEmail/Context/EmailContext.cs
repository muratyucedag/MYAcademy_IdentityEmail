using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using MYAcademy_IdentityEmail.Entities;

namespace MYAcademy_IdentityEmail.Context
{
    public class EmailContext : IdentityDbContext<AppUser>
    {
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer("Server=DESKTOP-R7AR1ND;initial catalog=IdentityEmailDbNight;integrated security=true;trust server certificate=true");
        }
        public DbSet<Category> Categories { get; set; }
        public DbSet<Message> Messages { get; set; }
    }
}
