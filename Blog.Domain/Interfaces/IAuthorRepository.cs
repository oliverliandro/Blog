using Blog.Domain.Models;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace Blog.Domain.Interfaces;
public interface IAuthorRepository
{
	Task<IEnumerable<Author>>GetAllAsync();
	Task<Author> GetByIdAsync(int id);
	Task<Author>AddAuthorAsync(Author author);
	Task DeleteAuthorAsync(Author author);
	Task UpdateAutorAsync(Author author);
}
