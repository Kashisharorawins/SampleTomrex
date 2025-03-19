using DotNetCoreDataAccessLayer.Entitites;
using Microsoft.EntityFrameworkCore;

namespace DotNetCoreDataAccessLayer.DbContextFile
{
    public class Context : DbContext
    {
        public Context(DbContextOptions<Context> options) : base(options)
        {
        }

        public DbSet<Students> Students { get; set; }
    }
}