using Azure;
using Blog.Domain.Interfaces;
using Blog.Domain.Models;
using Blog.Infra.Contexts;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Blog.Infra.Repositories
{
	public class TagRepository : ITagRepository
	{
		private readonly BlogContext _blogContext;

		public TagRepository(BlogContext blogContext)
		{
			_blogContext = blogContext;
		}

		public async Task<Tag> AddAuthorAsync(Tag tag)
		{
			_blogContext.Tags.Add(tag);
			await _blogContext.SaveChangesAsync();
			return tag;
		}

		public async Task DeleteAuthorAsync(Tag tag)
		{
			_blogContext.Tags.Remove(tag);
			await _blogContext.SaveChangesAsync();
		}

		public async Task<IEnumerable<Tag>> GetAllAsync()
		{			
			return await _blogContext.Tags.AsNoTracking().ToListAsync();			
		}

		public async Task<Tag?> GetTagByIdAsync(int id)
		{
			return await _blogContext.Tags.SingleOrDefaultAsync(x=> x.Id == id);
		}

		public async Task UpdateAutorAsync(Tag tag)
		{
			_blogContext.Tags.Update(tag);
			await _blogContext.SaveChangesAsync();
		}
	}
}
