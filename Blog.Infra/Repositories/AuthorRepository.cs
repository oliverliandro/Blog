using Blog.Domain.Interfaces;
using Blog.Domain.Models;
using Blog.Infra.Contexts;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.Extensions.Configuration;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Blog.Infra.Repositories
{
	public class AuthorRepository : IAuthorRepository
	{
		private readonly BlogContext _dbContext;

		public AuthorRepository(BlogContext dbContext)
		{
			_dbContext = dbContext;
		}

		public async Task<Author> AddAuthorAsync(Author author)
		{
			_dbContext.Authors.Add(author);
			await _dbContext.SaveChangesAsync();
			return author;
		}

		public async Task DeleteAuthorAsync(Author author)
		{
			_dbContext.Authors.Remove(author);
			await _dbContext.SaveChangesAsync();
		}

		public async Task<IEnumerable<Author>> GetAllAsync()
		{
			return await _dbContext.Authors.AsNoTracking().ToListAsync();
		}

		public async Task<Author?> GetByIdAsync(int id)
		{
			return await _dbContext.Authors.SingleOrDefaultAsync(author => author.Id == id);
		}

		public async Task UpdateAutorAsync(Author author)
		{
			_dbContext.Update(author);
			await _dbContext.SaveChangesAsync();
		}
	}
}
