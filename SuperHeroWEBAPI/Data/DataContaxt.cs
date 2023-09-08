using Microsoft.EntityFrameworkCore;

namespace SuperHeroWEBAPI.Data
{
    public class DataContaxt : DbContext
    {
        public DataContaxt(DbContextOptions<DataContaxt> options) 
            : base(options)
        {

        }

        public DbSet<SuperHero> SuperHeroes { get; set; }
        //SuperHeroes is name of the table
    }
}
