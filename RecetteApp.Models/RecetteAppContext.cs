using Microsoft.EntityFrameworkCore;

namespace RecetteApp.Models
{
	public class RecetteAppContext : DbContext
	{
		public RecetteAppContext(DbContextOptions<RecetteAppContext> options)
			: base(options)
		{
		}
	}
}
