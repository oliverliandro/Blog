using Blog.Domain.Models;
using Microsoft.EntityFrameworkCore;


namespace Blog.Infra.Contexts
{
	public class BlogContext : DbContext
	{
		public BlogContext(DbContextOptions options) : base(options) { }

		public DbSet<Tag> Tags { get; set; }
		public DbSet<Author> Authors { get; set; }
		public DbSet<News> Posts { get; set; }

		protected override void OnModelCreating(ModelBuilder modelBuilder)
		{
			modelBuilder.ApplyConfigurationsFromAssembly(typeof(BlogContext).Assembly);
		}
	}
}
