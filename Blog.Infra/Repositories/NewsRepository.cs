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
	public  class NewsRepository: INewsRepository
	{
		private readonly BlogContext _blogContext;

		public NewsRepository(BlogContext blogContext)
		{
			_blogContext = blogContext;
		}

		public async Task<News> AddAuthorAsync(News news)
		{
			_blogContext.Posts.Add(news);
			await _blogContext.SaveChangesAsync();
			return news;
		}

		public async Task DeleteAuthorAsync(News news)
		{
			_blogContext.Posts.Remove(news);
			await _blogContext.SaveChangesAsync();
		}

		public async  Task<IEnumerable<News>> GetAllAsync()
		{
			return await _blogContext.Posts.AsNoTracking().ToListAsync();
		}

		public async Task<News?> GetByIdAsync(int id)
		{
			return await _blogContext.Posts.SingleOrDefaultAsync(x=> x.Id == id);
		}

		public async  Task UpdateAutorAsync(News news)
		{
			_blogContext.Posts.Update(news);
			await _blogContext.SaveChangesAsync();
		}
	}
}
