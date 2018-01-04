using System.Data.Entity;

namespace BBS.Domain
{
    public class BbsContext : DbContext
    {
        public BbsContext() : base("name=MAIN") { }

        public DbSet<User> Users { get; set; }
        public DbSet<Role> Roles { get; set; }
        public DbSet<Gender> Genders{ get; set; }
    }
}
