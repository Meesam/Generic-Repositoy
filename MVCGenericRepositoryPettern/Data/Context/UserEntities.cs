using System.Data.Entity;
using Data.Entity;

namespace Data.Context
{
    public partial class UserEntities:DbContext
    {
        public UserEntities()
            : base("name=DefaultConnection")
        {   
        }
        public DbSet<Users> Users { get; set; }
    }
}
