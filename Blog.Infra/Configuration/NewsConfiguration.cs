using Blog.Domain.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Blog.Infra.Configuration
{
	public class NewsConfiguration : IEntityTypeConfiguration<News>
	{
		public void Configure(EntityTypeBuilder<News> builder)
		{
			builder.ToTable(nameof(News));
			builder.HasKey(x => x.Id);
			builder.Property(p => p.Id).UseIdentityColumn();
			builder.Property(p => p.Title).HasMaxLength(70).IsRequired();
			builder.Property(p=> p.Subject).HasMaxLength(50).IsRequired();
			builder.Property(p => p.PublicationDate).HasDefaultValue(DateTime.UtcNow);
			builder.Property(p => p.Content).IsRequired();

	
				// Relacionamentos
			builder.HasOne(r => r.Author).WithMany(r => r.Posts);

			builder.HasMany(x => x.Tags)
				.WithMany(x => x.Posts)
				.UsingEntity<Dictionary<string, object>>(
					"PostTag",
					post => post
						.HasOne<Tag>()
						.WithMany()
						.HasForeignKey("PostId")
						.HasConstraintName("FK_PostRole_PostId")
						.OnDelete(DeleteBehavior.Cascade),
					tag => tag
						.HasOne<News>()
						.WithMany()
						.HasForeignKey("TagId")
						.HasConstraintName("FK_PostTag_TagId")
						.OnDelete(DeleteBehavior.Cascade));
		}
	}
}