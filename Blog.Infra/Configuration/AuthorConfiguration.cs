using Blog.Domain.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Blog.Infra.Configuration
{
	public class AuthorConfiguration : IEntityTypeConfiguration<Author>
	{
		public void Configure(EntityTypeBuilder<Author> builder)
		{
			builder.ToTable(nameof(Author));
			builder.HasKey(t => t.Id);

			builder.Property(t => t.Id).UseIdentityColumn();
			builder.Property(p=> p.Name).HasMaxLength(70).IsRequired();

		}
	}
}
