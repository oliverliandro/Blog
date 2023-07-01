using Blog.Domain.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Blog.Domain.Interfaces;

public  interface INewsRepository
{
	Task<IEnumerable<News>> GetAllAsync();
	Task<News> GetByIdAsync(int id);
	Task<News> AddAuthorAsync(News news);
	Task DeleteAuthorAsync(News news);
	Task UpdateAutorAsync(News news);
}
