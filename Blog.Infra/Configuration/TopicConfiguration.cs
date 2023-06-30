using Blog.Domain.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Blog.Infra.Configuration;

public class TopicConfiguration : IEntityTypeConfiguration<Tag>
{
	public void Configure(EntityTypeBuilder<Tag> builder)
	{
		builder.ToTable(nameof(Tag));
		builder.HasKey(t => t.Id);

		builder.Property(p => p.Id).UseIdentityColumn();
		builder.Property(p=> p.TagName).HasMaxLength(20).IsRequired();
	}
}
