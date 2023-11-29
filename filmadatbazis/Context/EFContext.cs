using System;
using Microsoft.EntityFrameworkCore;

namespace filmadatbazis.Context
{
	public class EFContext : DbContext
	{
		public EFContext()
		{
		}

		protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
		{
			optionsBuilder.UseSqlite("Data Source=.//DB//heroes.db");
		}
	}
}

