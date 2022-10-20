using Microsoft.EntityFrameworkCore;
using Stepankiv_S_Volont.Models;

namespace Stepankiv_S_Volont.Data
{
    public class AppDB : DbContext
    {

        public AppDB(DbContextOptions<AppDB> options) : base(options)
        {
                
        }
        public DbSet<Category> Categories { get; set; }
    }
}
