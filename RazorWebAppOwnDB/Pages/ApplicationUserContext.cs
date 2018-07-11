using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using RazorWebAppOwnDB.Pages;

// Context object connects to the database, maps to database records
namespace RazorWebAppOwnDB.Models
{
    public class ApplicationUserContext : DbContext
    {
        public ApplicationUserContext(DbContextOptions<ApplicationUserContext> options)
                : base(options)
        {
        }

        public DbSet<ApplicationUser> ApplicationUser { get; set; }
    }
}
