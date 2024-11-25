using Microsoft.AspNet.Identity.EntityFramework;
using Microsoft.EntityFrameworkCore;

namespace CoffeeCampus
{
	public class coffeeCampus : IdentityDbContext
	{
        public coffeeCampus(DbContextOptions options) 

        {

		}

		// Definer dine DbSets her
		//public DbSet<> YourEntities { get; set; }
	}
}
