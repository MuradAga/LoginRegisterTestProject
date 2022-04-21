using LoginRegisterTestProject.Entities;
using Microsoft.EntityFrameworkCore;

namespace LoginRegisterTestProject.Database_Context
{
    public class DataContext : DbContext
    {
        public DataContext(DbContextOptions<DataContext> dbContextOptions) : base(dbContextOptions)
        {

        }
        public DbSet<User> Users { get; set; }
    }
}
