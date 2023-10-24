using Advertise_mgmt_system.Areas.Identity.Data;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using Advertise_mgmt_system.Models;
using System.Reflection.Emit;

namespace Advertise_mgmt_system.Data;

public class AuthDbContext : IdentityDbContext<ApplicationUser>
{
    public AuthDbContext(DbContextOptions<AuthDbContext> options)
        : base(options)
    {
    }
    public DbSet<Category> CategoryDetails { get; set; }

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        base.OnModelCreating(modelBuilder);
        modelBuilder.Entity<Category>().HasData(
          new Category { Id = 1, Adv_Name = "Education", Adv_Theme = "Educational", Adv_Description = "This Advertise is to get Admissions into respective College/School in Town!" },
          new Category { Id = 2, Adv_Name = "Travel", Adv_Theme = "Explore_World", Adv_Description = "Explore New Worlds With Bare Minimum Flight bookings" },
          new Category { Id = 3, Adv_Name = "Recruitment", Adv_Theme = "Recruiting", Adv_Description = "Recruitment of new Tech. Company called FApple The way of Apple :)" }
       );
        // Customize the ASP.NET Identity model and override the defaults if needed.
        // For example, you can rename the ASP.NET Identity table names and more.
        // Add your customizations after calling base.OnModelCreating(builder);
    }

}
