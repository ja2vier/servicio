using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using WSCore.Models;

namespace WSCore.Models
{
	public class ModelContext : DbContext
	{
		public ModelContext()
		{
		}
		public ModelContext(DbContextOptions<ModelContext> options) : base(options)
		{

		}
		public DbSet<Login> Login { get; set; }
		public DbSet<Registro> Registro { get; set; }
		protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
		{
			if (!optionsBuilder.IsConfigured)
			{
				optionsBuilder.UseSqlServer(@"Data Source = localhost\\SQLEXPRESS;  Initial Catalog = WebServicesCore; Integrated Security = True;");


			}
		}
	}
}
