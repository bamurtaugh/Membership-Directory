using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;

// MemberContext object connects to the database, maps Members to database records
namespace RazorWebAppOwnDB.Models
{
    public class MemberContext : DbContext 
    {
        public MemberContext(DbContextOptions<MemberContext> options)
                : base(options)
        {
        }

        public DbSet<Member> Member { get; set; }
    }
}
