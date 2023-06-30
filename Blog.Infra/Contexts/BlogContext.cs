using Blog.Domain.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Blog.Infra.Contexts
{
	public class BlogContext : DbContext
	{
		public BlogContext(DbContextOptions options) : base(options) { }

		DbSet<Tag> Tags { get; set; }
		DbSet<Author> Authors { get; set; }
		DbSet<News> Tidings { get; set; }

		protected override void OnModelCreating(ModelBuilder modelBuilder)
		{
			modelBuilder.ApplyConfigurationsFromAssembly(typeof(BlogContext).Assembly);
		}
	}
}
